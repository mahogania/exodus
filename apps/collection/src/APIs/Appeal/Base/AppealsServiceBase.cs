using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class AppealsServiceBase : IAppealsService
{
    protected readonly CollectionDbContext _context;

    public AppealsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one APPEAL
    /// </summary>
    public async Task<Appeal> CreateAppeal(AppealCreateInput createDto)
    {
        var appeal = new AppealDbModel
        {
            AttachedFileId = createDto.AttachedFileId,
            CreatedAt = createDto.CreatedAt,
            DeletionFlag = createDto.DeletionFlag,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FineImpositionRequestNumber = createDto.FineImpositionRequestNumber,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NumberOfOpinions = createDto.NumberOfOpinions,
            OfficeCode = createDto.OfficeCode,
            OpinionContent = createDto.OpinionContent,
            RegistrationDateAndTime = createDto.RegistrationDateAndTime,
            ResponseContent = createDto.ResponseContent,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            appeal.Id = createDto.Id;
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
    /// Delete one APPEAL
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
    /// Find many APPEALS
    /// </summary>
    public async Task<List<Appeal>> Appeals(AppealFindManyArgs findManyArgs)
    {
        var appeals = await _context
            .Appeals.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return appeals.ConvertAll(appeal => appeal.ToDto());
    }

    /// <summary>
    /// Meta data about APPEAL records
    /// </summary>
    public async Task<MetadataDto> AppealsMeta(AppealFindManyArgs findManyArgs)
    {
        var count = await _context.Appeals.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one APPEAL
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
    /// Update one APPEAL
    /// </summary>
    public async Task UpdateAppeal(AppealWhereUniqueInput uniqueId, AppealUpdateInput updateDto)
    {
        var appeal = updateDto.ToModel(uniqueId);

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
}
