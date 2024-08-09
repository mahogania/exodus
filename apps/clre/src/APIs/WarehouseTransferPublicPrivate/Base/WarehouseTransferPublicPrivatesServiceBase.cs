using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class WarehouseTransferPublicPrivatesServiceBase
    : IWarehouseTransferPublicPrivatesService
{
    protected readonly ClreDbContext _context;

    public WarehouseTransferPublicPrivatesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    public async Task<WarehouseTransferPublicPrivate> CreateWarehouseTransferPublicPrivate(
        WarehouseTransferPublicPrivateCreateInput createDto
    )
    {
        var warehouseTransferPublicPrivate = new WarehouseTransferPublicPrivateDbModel
        {
            Address = createDto.Address,
            ApcCode = createDto.ApcCode,
            CreatedAt = createDto.CreatedAt,
            CustomsClearanceOfficeOfDeclaration = createDto.CustomsClearanceOfficeOfDeclaration,
            CustomsClearanceOfficeOfTheOperation = createDto.CustomsClearanceOfficeOfTheOperation,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeclarationDate = createDto.DeclarationDate,
            DeclarationNumber = createDto.DeclarationNumber,
            DesignationOfTheSubCustomsZone = createDto.DesignationOfTheSubCustomsZone,
            EpcCode = createDto.EpcCode,
            ExpiryDate = createDto.ExpiryDate,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            ImporterSAddress = createDto.ImporterSAddress,
            ImporterSName = createDto.ImporterSName,
            LabelApc = createDto.LabelApc,
            LabelEpc = createDto.LabelEpc,
            NameAndBusinessName = createDto.NameAndBusinessName,
            Nif = createDto.Nif,
            NifStatus = createDto.NifStatus,
            NumberOfArticles = createDto.NumberOfArticles,
            NumberOfTheImporterSTradeRegister = createDto.NumberOfTheImporterSTradeRegister,
            PurposeOfTheRequest = createDto.PurposeOfTheRequest,
            RcStatus = createDto.RcStatus,
            ReasonForTheRequest = createDto.ReasonForTheRequest,
            RectificationFrequency = createDto.RectificationFrequency,
            RequestNumberOfRegime = createDto.RequestNumberOfRegime,
            RequestedEndDate = createDto.RequestedEndDate,
            RequestedStartDate = createDto.RequestedStartDate,
            SuppressionOn = createDto.SuppressionOn,
            TradeRegisterNumberOfTheImporter = createDto.TradeRegisterNumberOfTheImporter,
            TypeOfTheSubCustomsZone = createDto.TypeOfTheSubCustomsZone,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            warehouseTransferPublicPrivate.Id = createDto.Id;
        }

        _context.WarehouseTransferPublicPrivates.Add(warehouseTransferPublicPrivate);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<WarehouseTransferPublicPrivateDbModel>(
            warehouseTransferPublicPrivate.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    public async Task DeleteWarehouseTransferPublicPrivate(
        WarehouseTransferPublicPrivateWhereUniqueInput uniqueId
    )
    {
        var warehouseTransferPublicPrivate =
            await _context.WarehouseTransferPublicPrivates.FindAsync(uniqueId.Id);
        if (warehouseTransferPublicPrivate == null)
        {
            throw new NotFoundException();
        }

        _context.WarehouseTransferPublicPrivates.Remove(warehouseTransferPublicPrivate);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many WAREHOUSE TRANSFER (PUBLIC, PRIVATE)s
    /// </summary>
    public async Task<List<WarehouseTransferPublicPrivate>> WarehouseTransferPublicPrivates(
        WarehouseTransferPublicPrivateFindManyArgs findManyArgs
    )
    {
        var warehouseTransferPublicPrivates = await _context
            .WarehouseTransferPublicPrivates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return warehouseTransferPublicPrivates.ConvertAll(warehouseTransferPublicPrivate =>
            warehouseTransferPublicPrivate.ToDto()
        );
    }

    /// <summary>
    /// Meta data about WAREHOUSE TRANSFER (PUBLIC, PRIVATE) records
    /// </summary>
    public async Task<MetadataDto> WarehouseTransferPublicPrivatesMeta(
        WarehouseTransferPublicPrivateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .WarehouseTransferPublicPrivates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    public async Task<WarehouseTransferPublicPrivate> WarehouseTransferPublicPrivate(
        WarehouseTransferPublicPrivateWhereUniqueInput uniqueId
    )
    {
        var warehouseTransferPublicPrivates = await this.WarehouseTransferPublicPrivates(
            new WarehouseTransferPublicPrivateFindManyArgs
            {
                Where = new WarehouseTransferPublicPrivateWhereInput { Id = uniqueId.Id }
            }
        );
        var warehouseTransferPublicPrivate = warehouseTransferPublicPrivates.FirstOrDefault();
        if (warehouseTransferPublicPrivate == null)
        {
            throw new NotFoundException();
        }

        return warehouseTransferPublicPrivate;
    }

    /// <summary>
    /// Update one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    public async Task UpdateWarehouseTransferPublicPrivate(
        WarehouseTransferPublicPrivateWhereUniqueInput uniqueId,
        WarehouseTransferPublicPrivateUpdateInput updateDto
    )
    {
        var warehouseTransferPublicPrivate = updateDto.ToModel(uniqueId);

        _context.Entry(warehouseTransferPublicPrivate).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.WarehouseTransferPublicPrivates.Any(e =>
                    e.Id == warehouseTransferPublicPrivate.Id
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
