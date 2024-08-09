using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class CustomsDetailedDeclarationTaxesServiceBase
    : ICustomsDetailedDeclarationTaxesService
{
    protected readonly ClreDbContext _context;

    public CustomsDetailedDeclarationTaxesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    public async Task<CustomsDetailedDeclarationTax> CreateCustomsDetailedDeclarationTax(
        CustomsDetailedDeclarationTaxCreateInput createDto
    )
    {
        var customsDetailedDeclarationTax = new CustomsDetailedDeclarationTaxDbModel
        {
            ArticleNumber = createDto.ArticleNumber,
            BasicTaxAmount = createDto.BasicTaxAmount,
            BasicTaxableBaseAmount = createDto.BasicTaxableBaseAmount,
            BasicTaxationRate = createDto.BasicTaxationRate,
            CautionAmountAfterExemptionOfGuarantee =
                createDto.CautionAmountAfterExemptionOfGuarantee,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            ExemptAmount = createDto.ExemptAmount,
            ExemptTaxationRate = createDto.ExemptTaxationRate,
            ExemptionBaseAmount = createDto.ExemptionBaseAmount,
            ExemptionTypeCode = createDto.ExemptionTypeCode,
            FinalModifierSId = createDto.FinalModifierSId,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            PaidTaxAmount = createDto.PaidTaxAmount,
            PaymentTypeCode = createDto.PaymentTypeCode,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceNumber = createDto.ReferenceNumber,
            SuppressionOn = createDto.SuppressionOn,
            TariffCategoryCode = createDto.TariffCategoryCode,
            TaxAdvantageCode = createDto.TaxAdvantageCode,
            TaxAmount = createDto.TaxAmount,
            TaxCode = createDto.TaxCode,
            TaxableBaseAmount = createDto.TaxableBaseAmount,
            TaxationRate = createDto.TaxationRate,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            customsDetailedDeclarationTax.Id = createDto.Id;
        }

        _context.CustomsDetailedDeclarationTaxes.Add(customsDetailedDeclarationTax);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CustomsDetailedDeclarationTaxDbModel>(
            customsDetailedDeclarationTax.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    public async Task DeleteCustomsDetailedDeclarationTax(
        CustomsDetailedDeclarationTaxWhereUniqueInput uniqueId
    )
    {
        var customsDetailedDeclarationTax =
            await _context.CustomsDetailedDeclarationTaxes.FindAsync(uniqueId.Id);
        if (customsDetailedDeclarationTax == null)
        {
            throw new NotFoundException();
        }

        _context.CustomsDetailedDeclarationTaxes.Remove(customsDetailedDeclarationTax);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many CUSTOMS DETAILED DECLARATION TAXES
    /// </summary>
    public async Task<List<CustomsDetailedDeclarationTax>> CustomsDetailedDeclarationTaxes(
        CustomsDetailedDeclarationTaxFindManyArgs findManyArgs
    )
    {
        var customsDetailedDeclarationTaxes = await _context
            .CustomsDetailedDeclarationTaxes.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return customsDetailedDeclarationTaxes.ConvertAll(customsDetailedDeclarationTax =>
            customsDetailedDeclarationTax.ToDto()
        );
    }

    /// <summary>
    /// Meta data about CUSTOMS DETAILED DECLARATION TAX records
    /// </summary>
    public async Task<MetadataDto> CustomsDetailedDeclarationTaxesMeta(
        CustomsDetailedDeclarationTaxFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CustomsDetailedDeclarationTaxes.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    public async Task<CustomsDetailedDeclarationTax> CustomsDetailedDeclarationTax(
        CustomsDetailedDeclarationTaxWhereUniqueInput uniqueId
    )
    {
        var customsDetailedDeclarationTaxes = await this.CustomsDetailedDeclarationTaxes(
            new CustomsDetailedDeclarationTaxFindManyArgs
            {
                Where = new CustomsDetailedDeclarationTaxWhereInput { Id = uniqueId.Id }
            }
        );
        var customsDetailedDeclarationTax = customsDetailedDeclarationTaxes.FirstOrDefault();
        if (customsDetailedDeclarationTax == null)
        {
            throw new NotFoundException();
        }

        return customsDetailedDeclarationTax;
    }

    /// <summary>
    /// Update one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    public async Task UpdateCustomsDetailedDeclarationTax(
        CustomsDetailedDeclarationTaxWhereUniqueInput uniqueId,
        CustomsDetailedDeclarationTaxUpdateInput updateDto
    )
    {
        var customsDetailedDeclarationTax = updateDto.ToModel(uniqueId);

        _context.Entry(customsDetailedDeclarationTax).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.CustomsDetailedDeclarationTaxes.Any(e =>
                    e.Id == customsDetailedDeclarationTax.Id
                )
            )
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
