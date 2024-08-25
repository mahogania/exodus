using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class AppealsServiceBase : IAppealsService
{
    protected readonly TravelerDbContext _context;

    public AppealsServiceBase(TravelerDbContext context)
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
            AppealRequestContents = createDto.AppealRequestContents,
            AppealRequestResponseContents = createDto.AppealRequestResponseContents,
            CompetentCustomsOfficeCode = createDto.CompetentCustomsOfficeCode,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NumberOfAppeals = createDto.NumberOfAppeals,
            ReferenceNumber = createDto.ReferenceNumber,
            Reject = createDto.Reject,
            Remark = createDto.Remark,
            RequestDateAndTime = createDto.RequestDateAndTime,
            ResponseDateTime = createDto.ResponseDateTime,
            ResponsiblePersonId = createDto.ResponsiblePersonId,
            ResponsibleServiceCode = createDto.ResponsibleServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            appeal.Id = createDto.Id;
        }
        if (createDto.GeneralBondNote != null)
        {
            appeal.GeneralBondNote = await _context
                .GeneralBondNotes.Where(generalBondNote =>
                    createDto.GeneralBondNote.Id == generalBondNote.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.GeneralTravelerInformationTpds != null)
        {
            appeal.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
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
    /// Find many Appeals
    /// </summary>
    public async Task<List<Appeal>> Appeals(AppealFindManyArgs findManyArgs)
    {
        var appeals = await _context
            .Appeals.Include(x => x.GeneralTravelerInformationTpds)
            .Include(x => x.GeneralBondNote)
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

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            appeal.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
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
    /// Get a General Bond Note record for Appeal
    /// </summary>
    public async Task<GeneralBondNote> GetGeneralBondNote(AppealWhereUniqueInput uniqueId)
    {
        var appeal = await _context
            .Appeals.Where(appeal => appeal.Id == uniqueId.Id)
            .Include(appeal => appeal.GeneralBondNote)
            .FirstOrDefaultAsync();
        if (appeal == null)
        {
            throw new NotFoundException();
        }
        return appeal.GeneralBondNote.ToDto();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to Appeal
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        AppealWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .Appeals.Include(x => x.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(t =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (generalTravelerInformationTpds.Count == 0)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpdsToConnect = generalTravelerInformationTpds.Except(
            parent.GeneralTravelerInformationTpds
        );

        foreach (var generalTravelerInformationTpd in generalTravelerInformationTpdsToConnect)
        {
            parent.GeneralTravelerInformationTpds.Add(generalTravelerInformationTpd);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from Appeal
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        AppealWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .Appeals.Include(x => x.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(t =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var generalTravelerInformationTpd in generalTravelerInformationTpds)
        {
            parent.GeneralTravelerInformationTpds?.Remove(generalTravelerInformationTpd);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for Appeal
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        AppealWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs appealFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m => m.AppealId == uniqueId.Id)
            .ApplyWhere(appealFindManyArgs.Where)
            .ApplySkip(appealFindManyArgs.Skip)
            .ApplyTake(appealFindManyArgs.Take)
            .ApplyOrderBy(appealFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for Appeal
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        AppealWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var appeal = await _context
            .Appeals.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (appeal == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(a =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (generalTravelerInformationTpds.Count == 0)
        {
            throw new NotFoundException();
        }

        appeal.GeneralTravelerInformationTpds = generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }
}
