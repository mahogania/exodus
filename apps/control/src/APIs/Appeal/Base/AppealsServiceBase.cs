using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class AppealsServiceBase : IAppealsService
{
    protected readonly ControlDbContext _context;

    public AppealsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Appeal
    /// </summary>
    public async Task<Appeal> CreateAppeal(AppealCreateInput createDto)
    {
        var appeal = new AppealDbModel
        {
            AppealContent = createDto.AppealContent,
            AttachedFileId = createDto.AttachedFileId,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = createDto.DateAndTimeOfInitialRecord,
            DeletedOn = createDto.DeletedOn,
            FinalModifierId = createDto.FinalModifierId,
            InitialRecorderId = createDto.InitialRecorderId,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            appeal.Id = createDto.Id;
        }
        if (createDto.CommonVerifications != null)
        {
            appeal.CommonVerifications = await _context
                .CommonVerifications.Where(commonVerification =>
                    createDto.CommonVerifications.Select(t => t.Id).Contains(commonVerification.Id)
                )
                .ToListAsync();
        }

        _context.Appeals.Add(appeal);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<AppealDbModel>(appeal.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Appeal
    /// </summary>
    public async Task DeleteAppeal(AppealWhereUniqueInput uniqueId)
    {
        var appeal = await _context.Appeals.FindAsync(uniqueId.Id);
        if (appeal == null)
        {
            throw new NotFoundException();
        }

        _context.Appeals.Remove(appeal);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Appeal On The Result Of The Verification Of The Evaluation Of ValuesItems
    /// </summary>
    public async Task<List<Appeal>> Appeals(AppealFindManyArgs findManyArgs)
    {
        var appeals = await _context
            .Appeals.Include(x => x.CommonVerifications)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return appeals.ConvertAll(appeal => appeal.ToDto());
    }

    /// <summary>
    /// Meta data about Appeal records
    /// </summary>
    public async Task<MetadataDto> AppealsMeta(AppealFindManyArgs findManyArgs)
    {
        var count = await _context.Appeals.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Appeal
    /// </summary>
    public async Task<Appeal> Appeal(AppealWhereUniqueInput uniqueId)
    {
        var appeals = await this.Appeals(
            new AppealFindManyArgs { Where = new AppealWhereInput { Id = uniqueId.Id } }
        );
        var appeal = appeals.FirstOrDefault();
        if (appeal == null)
        {
            throw new NotFoundException();
        }

        return appeal;
    }

    /// <summary>
    /// Update one Appeal
    /// </summary>
    public async Task UpdateAppeal(AppealWhereUniqueInput uniqueId, AppealUpdateInput updateDto)
    {
        var appeal = updateDto.ToModel(uniqueId);

        if (updateDto.CommonVerifications != null)
        {
            appeal.CommonVerifications = await _context
                .CommonVerifications.Where(commonVerification =>
                    updateDto.CommonVerifications.Select(t => t).Contains(commonVerification.Id)
                )
                .ToListAsync();
        }

        _context.Entry(appeal).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Appeals.Any(e => e.Id == appeal.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Connect multiple Common Verifications records to Appeal
    /// </summary>
    public async Task ConnectCommonVerifications(
        AppealWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        var parent = await _context
            .Appeals.Include(x => x.CommonVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonVerifications = await _context
            .CommonVerifications.Where(t => commonVerificationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (commonVerifications.Count == 0)
        {
            throw new NotFoundException();
        }

        var commonVerificationsToConnect = commonVerifications.Except(parent.CommonVerifications);

        foreach (var commonVerification in commonVerificationsToConnect)
        {
            parent.CommonVerifications.Add(commonVerification);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Common Verifications records from Appeal
    /// </summary>
    public async Task DisconnectCommonVerifications(
        AppealWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        var parent = await _context
            .Appeals.Include(x => x.CommonVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonVerifications = await _context
            .CommonVerifications.Where(t => commonVerificationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var commonVerification in commonVerifications)
        {
            parent.CommonVerifications?.Remove(commonVerification);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Common Verifications records for Appeal
    /// </summary>
    public async Task<List<CommonVerification>> FindCommonVerifications(
        AppealWhereUniqueInput uniqueId,
        CommonVerificationFindManyArgs appealFindManyArgs
    )
    {
        var commonVerifications = await _context
            .CommonVerifications.Where(m => m.AppealId == uniqueId.Id)
            .ApplyWhere(appealFindManyArgs.Where)
            .ApplySkip(appealFindManyArgs.Skip)
            .ApplyTake(appealFindManyArgs.Take)
            .ApplyOrderBy(appealFindManyArgs.SortBy)
            .ToListAsync();

        return commonVerifications.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Common Verifications records for Appeal
    /// </summary>
    public async Task UpdateCommonVerifications(
        AppealWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        var appeal = await _context
            .Appeals.Include(t => t.CommonVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (appeal == null)
        {
            throw new NotFoundException();
        }

        var commonVerifications = await _context
            .CommonVerifications.Where(a => commonVerificationsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (commonVerifications.Count == 0)
        {
            throw new NotFoundException();
        }

        appeal.CommonVerifications = commonVerifications;
        await _context.SaveChangesAsync();
    }
}
