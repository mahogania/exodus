using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class DetailsServiceBase : IDetailsService
{
    protected readonly CollectionDbContext _context;

    public DetailsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one DETAIL
    /// </summary>
    public async Task<Detail> CreateDetail(DetailCreateInput createDto)
    {
        var detail = new DetailDbModel
        {
            AttachmentId = createDto.AttachmentId,
            ChassisNo = createDto.ChassisNo,
            ContainerNo = createDto.ContainerNo,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            EstimatedAuctionSalePrice = createDto.EstimatedAuctionSalePrice,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FinalUseCode = createDto.FinalUseCode,
            FirstCirculationDate = createDto.FirstCirculationDate,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            GrossWeight = createDto.GrossWeight,
            ItemSequenceNumber = createDto.ItemSequenceNumber,
            MaximumLoad = createDto.MaximumLoad,
            MerchandiseDescription = createDto.MerchandiseDescription,
            NumberOfSeats = createDto.NumberOfSeats,
            Quantity = createDto.Quantity,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = createDto.ReferenceNumberTypeName,
            RegistrationDate = createDto.RegistrationDate,
            RegistrationNumber = createDto.RegistrationNumber,
            RemarkContent = createDto.RemarkContent,
            StockAccountingManagementNumber = createDto.StockAccountingManagementNumber,
            UpdatedAt = createDto.UpdatedAt,
            VehicleBrandName = createDto.VehicleBrandName,
            VehicleCylinder = createDto.VehicleCylinder,
            VehicleEnergy = createDto.VehicleEnergy,
            VehicleModelName = createDto.VehicleModelName,
            VehicleOn = createDto.VehicleOn,
            VehiclePower = createDto.VehiclePower,
            VehicleType = createDto.VehicleType
        };

        if (createDto.Id != null) detail.Id = createDto.Id;

        _context.Details.Add(detail);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailDbModel>(detail.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one DETAIL
    /// </summary>
    public async Task DeleteDetail(DetailWhereUniqueInput uniqueId)
    {
        var detail = await _context.Details.FindAsync(uniqueId.Id);
        if (detail == null) throw new NotFoundException();

        _context.Details.Remove(detail);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many DETAILS
    /// </summary>
    public async Task<List<Detail>> Details(DetailFindManyArgs findManyArgs)
    {
        var details = await _context
            .Details.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return details.ConvertAll(detail => detail.ToDto());
    }

    /// <summary>
    ///     Meta data about DETAIL records
    /// </summary>
    public async Task<MetadataDto> DetailsMeta(DetailFindManyArgs findManyArgs)
    {
        var count = await _context.Details.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one DETAIL
    /// </summary>
    public async Task<Detail> Detail(DetailWhereUniqueInput uniqueId)
    {
        var details = await Details(
            new DetailFindManyArgs { Where = new DetailWhereInput { Id = uniqueId.Id } }
        );
        var detail = details.FirstOrDefault();
        if (detail == null) throw new NotFoundException();

        return detail;
    }

    /// <summary>
    ///     Update one DETAIL
    /// </summary>
    public async Task UpdateDetail(DetailWhereUniqueInput uniqueId, DetailUpdateInput updateDto)
    {
        var detail = updateDto.ToModel(uniqueId);

        _context.Entry(detail).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Details.Any(e => e.Id == detail.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
