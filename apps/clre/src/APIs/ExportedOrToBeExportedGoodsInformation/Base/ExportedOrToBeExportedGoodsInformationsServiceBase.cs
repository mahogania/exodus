using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class ExportedOrToBeExportedGoodsInformationsServiceBase
    : IExportedOrToBeExportedGoodsInformationsService
{
    protected readonly ClreDbContext _context;

    public ExportedOrToBeExportedGoodsInformationsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    public async Task<ExportedOrToBeExportedGoodsInformation> CreateExportedOrToBeExportedGoodsInformation(
        ExportedOrToBeExportedGoodsInformationCreateInput createDto
    )
    {
        var exportedOrToBeExportedGoodsInformation =
            new ExportedOrToBeExportedGoodsInformationDbModel
            {
                ArticleNumber = createDto.ArticleNumber,
                CommercialDesignationOfTheGoods = createDto.CommercialDesignationOfTheGoods,
                CreatedAt = createDto.CreatedAt,
                CurrencyCode = createDto.CurrencyCode,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                DestinationCountry = createDto.DestinationCountry,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                Quantity = createDto.Quantity,
                RectificationFrequency = createDto.RectificationFrequency,
                RegimeRequestNumber = createDto.RegimeRequestNumber,
                SequenceNumber = createDto.SequenceNumber,
                SptNumber = createDto.SptNumber,
                SuppressionOn = createDto.SuppressionOn,
                TechnicalDesignationOfTheGoods = createDto.TechnicalDesignationOfTheGoods,
                UpdatedAt = createDto.UpdatedAt,
                Value = createDto.Value
            };

        if (createDto.Id != null)
        {
            exportedOrToBeExportedGoodsInformation.Id = createDto.Id;
        }

        _context.ExportedOrToBeExportedGoodsInformations.Add(
            exportedOrToBeExportedGoodsInformation
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ExportedOrToBeExportedGoodsInformationDbModel>(
            exportedOrToBeExportedGoodsInformation.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    public async Task DeleteExportedOrToBeExportedGoodsInformation(
        ExportedOrToBeExportedGoodsInformationWhereUniqueInput uniqueId
    )
    {
        var exportedOrToBeExportedGoodsInformation =
            await _context.ExportedOrToBeExportedGoodsInformations.FindAsync(uniqueId.Id);
        if (exportedOrToBeExportedGoodsInformation == null)
        {
            throw new NotFoundException();
        }

        _context.ExportedOrToBeExportedGoodsInformations.Remove(
            exportedOrToBeExportedGoodsInformation
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many EXPORTED OR TO BE EXPORTED GOODS INFORMATIONS
    /// </summary>
    public async Task<
        List<ExportedOrToBeExportedGoodsInformation>
    > ExportedOrToBeExportedGoodsInformations(
        ExportedOrToBeExportedGoodsInformationFindManyArgs findManyArgs
    )
    {
        var exportedOrToBeExportedGoodsInformations = await _context
            .ExportedOrToBeExportedGoodsInformations.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return exportedOrToBeExportedGoodsInformations.ConvertAll(
            exportedOrToBeExportedGoodsInformation => exportedOrToBeExportedGoodsInformation.ToDto()
        );
    }

    /// <summary>
    /// Meta data about EXPORTED OR TO BE EXPORTED GOODS INFORMATION records
    /// </summary>
    public async Task<MetadataDto> ExportedOrToBeExportedGoodsInformationsMeta(
        ExportedOrToBeExportedGoodsInformationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ExportedOrToBeExportedGoodsInformations.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    public async Task<ExportedOrToBeExportedGoodsInformation> ExportedOrToBeExportedGoodsInformation(
        ExportedOrToBeExportedGoodsInformationWhereUniqueInput uniqueId
    )
    {
        var exportedOrToBeExportedGoodsInformations =
            await this.ExportedOrToBeExportedGoodsInformations(
                new ExportedOrToBeExportedGoodsInformationFindManyArgs
                {
                    Where = new ExportedOrToBeExportedGoodsInformationWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var exportedOrToBeExportedGoodsInformation =
            exportedOrToBeExportedGoodsInformations.FirstOrDefault();
        if (exportedOrToBeExportedGoodsInformation == null)
        {
            throw new NotFoundException();
        }

        return exportedOrToBeExportedGoodsInformation;
    }

    /// <summary>
    /// Update one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    public async Task UpdateExportedOrToBeExportedGoodsInformation(
        ExportedOrToBeExportedGoodsInformationWhereUniqueInput uniqueId,
        ExportedOrToBeExportedGoodsInformationUpdateInput updateDto
    )
    {
        var exportedOrToBeExportedGoodsInformation = updateDto.ToModel(uniqueId);

        _context.Entry(exportedOrToBeExportedGoodsInformation).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ExportedOrToBeExportedGoodsInformations.Any(e =>
                    e.Id == exportedOrToBeExportedGoodsInformation.Id
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
