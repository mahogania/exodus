using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CompensatoryProductsForPerfectionsServiceBase
    : ICompensatoryProductsForPerfectionsService
{
    protected readonly ControlDbContext _context;

    public CompensatoryProductsForPerfectionsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    public async Task<CompensatoryProductsForPerfection> CreateCompensatoryProductsForPerfection(
        CompensatoryProductsForPerfectionCreateInput createDto
    )
    {
        var compensatoryProductsForPerfection = new CompensatoryProductsForPerfectionDbModel
        {
            CommercialDesignationOfGoods = createDto.CommercialDesignationOfGoods,
            CountryOfExportation = createDto.CountryOfExportation,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            IntegrationRate = createDto.IntegrationRate,
            Origin = createDto.Origin,
            Quantity = createDto.Quantity,
            RealExporterOfGoods = createDto.RealExporterOfGoods,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SequenceNumber = createDto.SequenceNumber,
            SptNumber = createDto.SptNumber,
            TechnicalDesignationOfGoods = createDto.TechnicalDesignationOfGoods,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) compensatoryProductsForPerfection.Id = createDto.Id;

        _context.CompensatoryProductsForPerfections.Add(compensatoryProductsForPerfection);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CompensatoryProductsForPerfectionDbModel>(
            compensatoryProductsForPerfection.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    public async Task DeleteCompensatoryProductsForPerfection(
        CompensatoryProductsForPerfectionWhereUniqueInput uniqueId
    )
    {
        var compensatoryProductsForPerfection =
            await _context.CompensatoryProductsForPerfections.FindAsync(uniqueId.Id);
        if (compensatoryProductsForPerfection == null) throw new NotFoundException();

        _context.CompensatoryProductsForPerfections.Remove(compensatoryProductsForPerfection);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many COMPENSATORY PRODUCTS FOR PERFECTIONS
    /// </summary>
    public async Task<List<CompensatoryProductsForPerfection>> CompensatoryProductsForPerfections(
        CompensatoryProductsForPerfectionFindManyArgs findManyArgs
    )
    {
        var compensatoryProductsForPerfections = await _context
            .CompensatoryProductsForPerfections.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return compensatoryProductsForPerfections.ConvertAll(compensatoryProductsForPerfection =>
            compensatoryProductsForPerfection.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about COMPENSATORY PRODUCTS FOR PERFECTION records
    /// </summary>
    public async Task<MetadataDto> CompensatoryProductsForPerfectionsMeta(
        CompensatoryProductsForPerfectionFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CompensatoryProductsForPerfections.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    public async Task<CompensatoryProductsForPerfection> CompensatoryProductsForPerfection(
        CompensatoryProductsForPerfectionWhereUniqueInput uniqueId
    )
    {
        var compensatoryProductsForPerfections = await CompensatoryProductsForPerfections(
            new CompensatoryProductsForPerfectionFindManyArgs
            {
                Where = new CompensatoryProductsForPerfectionWhereInput { Id = uniqueId.Id }
            }
        );
        var compensatoryProductsForPerfection = compensatoryProductsForPerfections.FirstOrDefault();
        if (compensatoryProductsForPerfection == null) throw new NotFoundException();

        return compensatoryProductsForPerfection;
    }

    /// <summary>
    ///     Update one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    public async Task UpdateCompensatoryProductsForPerfection(
        CompensatoryProductsForPerfectionWhereUniqueInput uniqueId,
        CompensatoryProductsForPerfectionUpdateInput updateDto
    )
    {
        var compensatoryProductsForPerfection = updateDto.ToModel(uniqueId);

        _context.Entry(compensatoryProductsForPerfection).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.CompensatoryProductsForPerfections.Any(e =>
                    e.Id == compensatoryProductsForPerfection.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
