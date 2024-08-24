using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class WarehouseTransfersServiceBase : IWarehouseTransfersService
{
    protected readonly ControlDbContext _context;

    public WarehouseTransfersServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Warehouse Transfer
    /// </summary>
    public async Task<WarehouseTransfer> CreateWarehouseTransfer(
        WarehouseTransferCreateInput createDto
    )
    {
        var warehouseTransfer = new WarehouseTransferDbModel
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
            warehouseTransfer.Id = createDto.Id;
        }

        _context.WarehouseTransfers.Add(warehouseTransfer);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<WarehouseTransferDbModel>(warehouseTransfer.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Warehouse Transfer
    /// </summary>
    public async Task DeleteWarehouseTransfer(WarehouseTransferWhereUniqueInput uniqueId)
    {
        var warehouseTransfer = await _context.WarehouseTransfers.FindAsync(uniqueId.Id);
        if (warehouseTransfer == null)
        {
            throw new NotFoundException();
        }

        _context.WarehouseTransfers.Remove(warehouseTransfer);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many WAREHOUSE TRANSFER (PUBLIC, PRIVATE)s
    /// </summary>
    public async Task<List<WarehouseTransfer>> WarehouseTransfers(
        WarehouseTransferFindManyArgs findManyArgs
    )
    {
        var warehouseTransfers = await _context
            .WarehouseTransfers.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return warehouseTransfers.ConvertAll(warehouseTransfer => warehouseTransfer.ToDto());
    }

    /// <summary>
    /// Meta data about Warehouse Transfer records
    /// </summary>
    public async Task<MetadataDto> WarehouseTransfersMeta(
        WarehouseTransferFindManyArgs findManyArgs
    )
    {
        var count = await _context.WarehouseTransfers.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Warehouse Transfer
    /// </summary>
    public async Task<WarehouseTransfer> WarehouseTransfer(
        WarehouseTransferWhereUniqueInput uniqueId
    )
    {
        var warehouseTransfers = await this.WarehouseTransfers(
            new WarehouseTransferFindManyArgs
            {
                Where = new WarehouseTransferWhereInput { Id = uniqueId.Id }
            }
        );
        var warehouseTransfer = warehouseTransfers.FirstOrDefault();
        if (warehouseTransfer == null)
        {
            throw new NotFoundException();
        }

        return warehouseTransfer;
    }

    /// <summary>
    /// Update one Warehouse Transfer
    /// </summary>
    public async Task UpdateWarehouseTransfer(
        WarehouseTransferWhereUniqueInput uniqueId,
        WarehouseTransferUpdateInput updateDto
    )
    {
        var warehouseTransfer = updateDto.ToModel(uniqueId);

        _context.Entry(warehouseTransfer).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.WarehouseTransfers.Any(e => e.Id == warehouseTransfer.Id))
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
