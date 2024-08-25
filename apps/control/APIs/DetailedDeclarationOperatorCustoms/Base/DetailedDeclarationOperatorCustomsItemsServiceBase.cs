using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class DetailedDeclarationOperatorCustomsItemsServiceBase
    : IDetailedDeclarationOperatorCustomsItemsService
{
    protected readonly ControlDbContext _context;

    public DetailedDeclarationOperatorCustomsItemsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    public async Task<DetailedDeclarationOperatorCustoms> CreateDetailedDeclarationOperatorCustoms(
        DetailedDeclarationOperatorCustomsCreateInput createDto
    )
    {
        var detailedDeclarationOperatorCustoms = new DetailedDeclarationOperatorCustomsDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeclarantSAddress = createDto.DeclarantSAddress,
            DeletionOn = createDto.DeletionOn,
            ExporterSAddress = createDto.ExporterSAddress,
            ExporterSEmail = createDto.ExporterSEmail,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            ImporterSAddress = createDto.ImporterSAddress,
            NameOfTheDeclarantSCompany = createDto.NameOfTheDeclarantSCompany,
            NameOfTheExporterSCompany = createDto.NameOfTheExporterSCompany,
            NameOfTheImporterSCompany = createDto.NameOfTheImporterSCompany,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceNumber = createDto.ReferenceNumber,
            TaxpayerPhoneNumber = createDto.TaxpayerPhoneNumber,
            TaxpayerSAddress = createDto.TaxpayerSAddress,
            TaxpayerSCompanyName = createDto.TaxpayerSCompanyName,
            TaxpayerSEmail = createDto.TaxpayerSEmail,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) detailedDeclarationOperatorCustoms.Id = createDto.Id;

        _context.DetailedDeclarationOperatorCustomsItems.Add(detailedDeclarationOperatorCustoms);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailedDeclarationOperatorCustomsDbModel>(
            detailedDeclarationOperatorCustoms.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    public async Task DeleteDetailedDeclarationOperatorCustoms(
        DetailedDeclarationOperatorCustomsWhereUniqueInput uniqueId
    )
    {
        var detailedDeclarationOperatorCustoms =
            await _context.DetailedDeclarationOperatorCustomsItems.FindAsync(uniqueId.Id);
        if (detailedDeclarationOperatorCustoms == null) throw new NotFoundException();

        _context.DetailedDeclarationOperatorCustomsItems.Remove(detailedDeclarationOperatorCustoms);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many DETAILED DECLARATION OPERATOR (CUSTOMS)s
    /// </summary>
    public async Task<
        List<DetailedDeclarationOperatorCustoms>
    > DetailedDeclarationOperatorCustomsItems(
        DetailedDeclarationOperatorCustomsFindManyArgs findManyArgs
    )
    {
        var detailedDeclarationOperatorCustomsItems = await _context
            .DetailedDeclarationOperatorCustomsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return detailedDeclarationOperatorCustomsItems.ConvertAll(
            detailedDeclarationOperatorCustoms => detailedDeclarationOperatorCustoms.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about DETAILED DECLARATION OPERATOR (CUSTOMS) records
    /// </summary>
    public async Task<MetadataDto> DetailedDeclarationOperatorCustomsItemsMeta(
        DetailedDeclarationOperatorCustomsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DetailedDeclarationOperatorCustomsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    public async Task<DetailedDeclarationOperatorCustoms> DetailedDeclarationOperatorCustoms(
        DetailedDeclarationOperatorCustomsWhereUniqueInput uniqueId
    )
    {
        var detailedDeclarationOperatorCustomsItems =
            await DetailedDeclarationOperatorCustomsItems(
                new DetailedDeclarationOperatorCustomsFindManyArgs
                {
                    Where = new DetailedDeclarationOperatorCustomsWhereInput { Id = uniqueId.Id }
                }
            );
        var detailedDeclarationOperatorCustoms =
            detailedDeclarationOperatorCustomsItems.FirstOrDefault();
        if (detailedDeclarationOperatorCustoms == null) throw new NotFoundException();

        return detailedDeclarationOperatorCustoms;
    }

    /// <summary>
    ///     Update one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    public async Task UpdateDetailedDeclarationOperatorCustoms(
        DetailedDeclarationOperatorCustomsWhereUniqueInput uniqueId,
        DetailedDeclarationOperatorCustomsUpdateInput updateDto
    )
    {
        var detailedDeclarationOperatorCustoms = updateDto.ToModel(uniqueId);

        _context.Entry(detailedDeclarationOperatorCustoms).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DetailedDeclarationOperatorCustomsItems.Any(e =>
                    e.Id == detailedDeclarationOperatorCustoms.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
