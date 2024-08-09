using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class ImportedGoodsInformationsServiceBase : IImportedGoodsInformationsService
{
    protected readonly ClreDbContext _context;

    public ImportedGoodsInformationsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one IMPORTED GOODS INFORMATION
    /// </summary>
    public async Task<ImportedGoodsInformation> CreateImportedGoodsInformation(
        ImportedGoodsInformationCreateInput createDto
    )
    {
        var importedGoodsInformation = new ImportedGoodsInformationDbModel
        {
            AmountOfPaidDutiesAndTaxes = createDto.AmountOfPaidDutiesAndTaxes,
            ApcCode = createDto.ApcCode,
            ApcLabel = createDto.ApcLabel,
            CommercialDesignationOfGoods = createDto.CommercialDesignationOfGoods,
            CountryOfOrigin = createDto.CountryOfOrigin,
            CreatedAt = createDto.CreatedAt,
            CurrencyCode = createDto.CurrencyCode,
            CustomsDeclarationCodeOfTheImportation =
                createDto.CustomsDeclarationCodeOfTheImportation,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DateOfThePaymentOfDutiesAndTaxesReceipt =
                createDto.DateOfThePaymentOfDutiesAndTaxesReceipt,
            DeclarationStatus = createDto.DeclarationStatus,
            EpcCode = createDto.EpcCode,
            EpcLabel = createDto.EpcLabel,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            ImportationDeclarationNumber = createDto.ImportationDeclarationNumber,
            NumberOfArticles = createDto.NumberOfArticles,
            NumberOfThePaymentOfDutiesAndTaxesReceipt =
                createDto.NumberOfThePaymentOfDutiesAndTaxesReceipt,
            Quantity = createDto.Quantity,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SequenceNumber = createDto.SequenceNumber,
            SuppressionOn = createDto.SuppressionOn,
            TechnicalDesignationOfGoods = createDto.TechnicalDesignationOfGoods,
            UpdatedAt = createDto.UpdatedAt,
            Value = createDto.Value
        };

        if (createDto.Id != null)
        {
            importedGoodsInformation.Id = createDto.Id;
        }

        _context.ImportedGoodsInformations.Add(importedGoodsInformation);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ImportedGoodsInformationDbModel>(
            importedGoodsInformation.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one IMPORTED GOODS INFORMATION
    /// </summary>
    public async Task DeleteImportedGoodsInformation(
        ImportedGoodsInformationWhereUniqueInput uniqueId
    )
    {
        var importedGoodsInformation = await _context.ImportedGoodsInformations.FindAsync(
            uniqueId.Id
        );
        if (importedGoodsInformation == null)
        {
            throw new NotFoundException();
        }

        _context.ImportedGoodsInformations.Remove(importedGoodsInformation);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many IMPORTED GOODS INFORMATIONS
    /// </summary>
    public async Task<List<ImportedGoodsInformation>> ImportedGoodsInformations(
        ImportedGoodsInformationFindManyArgs findManyArgs
    )
    {
        var importedGoodsInformations = await _context
            .ImportedGoodsInformations.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return importedGoodsInformations.ConvertAll(importedGoodsInformation =>
            importedGoodsInformation.ToDto()
        );
    }

    /// <summary>
    /// Meta data about IMPORTED GOODS INFORMATION records
    /// </summary>
    public async Task<MetadataDto> ImportedGoodsInformationsMeta(
        ImportedGoodsInformationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ImportedGoodsInformations.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one IMPORTED GOODS INFORMATION
    /// </summary>
    public async Task<ImportedGoodsInformation> ImportedGoodsInformation(
        ImportedGoodsInformationWhereUniqueInput uniqueId
    )
    {
        var importedGoodsInformations = await this.ImportedGoodsInformations(
            new ImportedGoodsInformationFindManyArgs
            {
                Where = new ImportedGoodsInformationWhereInput { Id = uniqueId.Id }
            }
        );
        var importedGoodsInformation = importedGoodsInformations.FirstOrDefault();
        if (importedGoodsInformation == null)
        {
            throw new NotFoundException();
        }

        return importedGoodsInformation;
    }

    /// <summary>
    /// Update one IMPORTED GOODS INFORMATION
    /// </summary>
    public async Task UpdateImportedGoodsInformation(
        ImportedGoodsInformationWhereUniqueInput uniqueId,
        ImportedGoodsInformationUpdateInput updateDto
    )
    {
        var importedGoodsInformation = updateDto.ToModel(uniqueId);

        _context.Entry(importedGoodsInformation).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ImportedGoodsInformations.Any(e => e.Id == importedGoodsInformation.Id))
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
