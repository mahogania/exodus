using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class IssuancesServiceBase : IIssuancesService
{
    protected readonly CollectionDbContext _context;

    public IssuancesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one ISSUANCE
    /// </summary>
    public async Task<Issuance> CreateIssuance(IssuanceCreateInput createDto)
    {
        var issuance = new IssuanceDbModel
        {
            CollectionNo = createDto.CollectionNo,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            IssuingPersonId = createDto.IssuingPersonId,
            NumberOfIssuances = createDto.NumberOfIssuances,
            OfficeCode = createDto.OfficeCode,
            PublicationDate = createDto.PublicationDate,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) issuance.Id = createDto.Id;

        _context.Issuances.Add(issuance);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<IssuanceDbModel>(issuance.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one ISSUANCE
    /// </summary>
    public async Task DeleteIssuance(IssuanceWhereUniqueInput uniqueId)
    {
        var issuance = await _context.Issuances.FindAsync(uniqueId.Id);
        if (issuance == null) throw new NotFoundException();

        _context.Issuances.Remove(issuance);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many ISSUANCES
    /// </summary>
    public async Task<List<Issuance>> Issuances(IssuanceFindManyArgs findManyArgs)
    {
        var issuances = await _context
            .Issuances.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return issuances.ConvertAll(issuance => issuance.ToDto());
    }

    /// <summary>
    ///     Meta data about ISSUANCE records
    /// </summary>
    public async Task<MetadataDto> IssuancesMeta(IssuanceFindManyArgs findManyArgs)
    {
        var count = await _context.Issuances.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one ISSUANCE
    /// </summary>
    public async Task<Issuance> Issuance(IssuanceWhereUniqueInput uniqueId)
    {
        var issuances = await Issuances(
            new IssuanceFindManyArgs { Where = new IssuanceWhereInput { Id = uniqueId.Id } }
        );
        var issuance = issuances.FirstOrDefault();
        if (issuance == null) throw new NotFoundException();

        return issuance;
    }

    /// <summary>
    ///     Update one ISSUANCE
    /// </summary>
    public async Task UpdateIssuance(
        IssuanceWhereUniqueInput uniqueId,
        IssuanceUpdateInput updateDto
    )
    {
        var issuance = updateDto.ToModel(uniqueId);

        _context.Entry(issuance).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Issuances.Any(e => e.Id == issuance.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
