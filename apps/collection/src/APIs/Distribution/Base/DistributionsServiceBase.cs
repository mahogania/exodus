using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class DistributionsServiceBase : IDistributionsService
{
    protected readonly CollectionDbContext _context;

    public DistributionsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one DISTRIBUTION
    /// </summary>
    public async Task<Distribution> CreateDistribution(DistributionCreateInput createDto)
    {
        var distribution = new DistributionDbModel
        {
            AccountCode = createDto.AccountCode,
            CollectedAmount = createDto.CollectedAmount,
            CollectionNo = createDto.CollectionNo,
            CreatedAt = createDto.CreatedAt,
            DebitOrCreditDesignationCode = createDto.DebitOrCreditDesignationCode,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NoticeNo = createDto.NoticeNo,
            NoticeTypeCode = createDto.NoticeTypeCode,
            NotificationDate = createDto.NotificationDate,
            OfficeCode = createDto.OfficeCode,
            PaymentDate = createDto.PaymentDate,
            ProcessingOn = createDto.ProcessingOn,
            ServiceCode = createDto.ServiceCode,
            TaxCode = createDto.TaxCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) distribution.Id = createDto.Id;

        _context.Distributions.Add(distribution);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DistributionDbModel>(distribution.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one DISTRIBUTION
    /// </summary>
    public async Task DeleteDistribution(DistributionWhereUniqueInput uniqueId)
    {
        var distribution = await _context.Distributions.FindAsync(uniqueId.Id);
        if (distribution == null) throw new NotFoundException();

        _context.Distributions.Remove(distribution);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many DISTRIBUTIONS
    /// </summary>
    public async Task<List<Distribution>> Distributions(DistributionFindManyArgs findManyArgs)
    {
        var distributions = await _context
            .Distributions.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return distributions.ConvertAll(distribution => distribution.ToDto());
    }

    /// <summary>
    ///     Meta data about DISTRIBUTION records
    /// </summary>
    public async Task<MetadataDto> DistributionsMeta(DistributionFindManyArgs findManyArgs)
    {
        var count = await _context.Distributions.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one DISTRIBUTION
    /// </summary>
    public async Task<Distribution> Distribution(DistributionWhereUniqueInput uniqueId)
    {
        var distributions = await Distributions(
            new DistributionFindManyArgs { Where = new DistributionWhereInput { Id = uniqueId.Id } }
        );
        var distribution = distributions.FirstOrDefault();
        if (distribution == null) throw new NotFoundException();

        return distribution;
    }

    /// <summary>
    ///     Update one DISTRIBUTION
    /// </summary>
    public async Task UpdateDistribution(
        DistributionWhereUniqueInput uniqueId,
        DistributionUpdateInput updateDto
    )
    {
        var distribution = updateDto.ToModel(uniqueId);

        _context.Entry(distribution).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Distributions.Any(e => e.Id == distribution.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
