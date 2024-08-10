using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CustomsClearanceOfPostalGoodsItemsServiceBase
    : ICustomsClearanceOfPostalGoodsItemsService
{
    protected readonly ControlDbContext _context;

    public CustomsClearanceOfPostalGoodsItemsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public async Task<CustomsClearanceOfPostalGoods> CreateCustomsClearanceOfPostalGoods(
        CustomsClearanceOfPostalGoodsCreateInput createDto
    )
    {
        var customsClearanceOfPostalGoods = new CustomsClearanceOfPostalGoodsDbModel
        {
            ArrivalDate = createDto.ArrivalDate,
            AttachedFileId = createDto.AttachedFileId,
            BagIdentifier = createDto.BagIdentifier,
            CategoryCode = createDto.CategoryCode,
            CategoryOfTreatmentCode = createDto.CategoryOfTreatmentCode,
            CodeOfPostOfficeHandlingInternationalParcels =
                createDto.CodeOfPostOfficeHandlingInternationalParcels,
            CountryOfOriginCode = createDto.CountryOfOriginCode,
            CountryOfShipmentCode = createDto.CountryOfShipmentCode,
            CreatedAt = createDto.CreatedAt,
            CurrencyCodeForPostalPackageValue = createDto.CurrencyCodeForPostalPackageValue,
            CustomsOfficeCode = createDto.CustomsOfficeCode,
            DeclaredCurrencyCodeForInsurance = createDto.DeclaredCurrencyCodeForInsurance,
            DeclaredInsuranceAmount = createDto.DeclaredInsuranceAmount,
            DeletionOn = createDto.DeletionOn,
            DestinationRouting = createDto.DestinationRouting,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            FlightNumber = createDto.FlightNumber,
            GrossWeight = createDto.GrossWeight,
            ImportExportTypeCode = createDto.ImportExportTypeCode,
            MailClass = createDto.MailClass,
            ModeOfTransportCode = createDto.ModeOfTransportCode,
            NameOfOriginPostOffice = createDto.NameOfOriginPostOffice,
            NameOfPostOfficeHandlingInternationalParcels =
                createDto.NameOfPostOfficeHandlingInternationalParcels,
            Observations = createDto.Observations,
            OperationType = createDto.OperationType,
            OrdinaryCustomsClearanceOn = createDto.OrdinaryCustomsClearanceOn,
            OriginPost = createDto.OriginPost,
            PostalNumber = createDto.PostalNumber,
            PostalPackageCustomsClearanceRequestNumber =
                createDto.PostalPackageCustomsClearanceRequestNumber,
            PostalPackageValue = createDto.PostalPackageValue,
            ReceiverSEmail = createDto.ReceiverSEmail,
            ReceiverSId = createDto.ReceiverSId,
            ReceptionDateAlgerPort = createDto.ReceptionDateAlgerPort,
            RecipientAddressAddress1 = createDto.RecipientAddressAddress1,
            RecipientAddressAddress2 = createDto.RecipientAddressAddress2,
            RecipientAddressCity = createDto.RecipientAddressCity,
            RecipientAddressCountryCode = createDto.RecipientAddressCountryCode,
            RecipientSFixedPhoneNumber = createDto.RecipientSFixedPhoneNumber,
            RecipientSPostalCode = createDto.RecipientSPostalCode,
            RequestDate = createDto.RequestDate,
            RequesterSId = createDto.RequesterSId,
            ShipperSAddress = createDto.ShipperSAddress,
            ShipperSAddress_2 = createDto.ShipperSAddress_2,
            ShipperSCity = createDto.ShipperSCity,
            ShipperSEmail = createDto.ShipperSEmail,
            ShipperSId = createDto.ShipperSId,
            ShipperSName = createDto.ShipperSName,
            ShipperSPhoneNumber = createDto.ShipperSPhoneNumber,
            ShipperSPostalCode = createDto.ShipperSPostalCode,
            ShippingDate = createDto.ShippingDate,
            SimplifiedCustomsClearanceOn = createDto.SimplifiedCustomsClearanceOn,
            TotalTaxAmount = createDto.TotalTaxAmount,
            TransportDate = createDto.TransportDate,
            TreatmentCode = createDto.TreatmentCode,
            TreatmentStatusCode = createDto.TreatmentStatusCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) customsClearanceOfPostalGoods.Id = createDto.Id;

        _context.CustomsClearanceOfPostalGoodsItems.Add(customsClearanceOfPostalGoods);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CustomsClearanceOfPostalGoodsDbModel>(
            customsClearanceOfPostalGoods.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public async Task DeleteCustomsClearanceOfPostalGoods(
        CustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    )
    {
        var customsClearanceOfPostalGoods =
            await _context.CustomsClearanceOfPostalGoodsItems.FindAsync(uniqueId.Id);
        if (customsClearanceOfPostalGoods == null) throw new NotFoundException();

        _context.CustomsClearanceOfPostalGoodsItems.Remove(customsClearanceOfPostalGoods);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many CUSTOMS CLEARANCE OF POSTAL GOODSItems
    /// </summary>
    public async Task<List<CustomsClearanceOfPostalGoods>> CustomsClearanceOfPostalGoodsItems(
        CustomsClearanceOfPostalGoodsFindManyArgs findManyArgs
    )
    {
        var customsClearanceOfPostalGoodsItems = await _context
            .CustomsClearanceOfPostalGoodsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return customsClearanceOfPostalGoodsItems.ConvertAll(customsClearanceOfPostalGoods =>
            customsClearanceOfPostalGoods.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about CUSTOMS CLEARANCE OF POSTAL GOODS records
    /// </summary>
    public async Task<MetadataDto> CustomsClearanceOfPostalGoodsItemsMeta(
        CustomsClearanceOfPostalGoodsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CustomsClearanceOfPostalGoodsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public async Task<CustomsClearanceOfPostalGoods> CustomsClearanceOfPostalGoods(
        CustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    )
    {
        var customsClearanceOfPostalGoodsItems = await CustomsClearanceOfPostalGoodsItems(
            new CustomsClearanceOfPostalGoodsFindManyArgs
            {
                Where = new CustomsClearanceOfPostalGoodsWhereInput { Id = uniqueId.Id }
            }
        );
        var customsClearanceOfPostalGoods = customsClearanceOfPostalGoodsItems.FirstOrDefault();
        if (customsClearanceOfPostalGoods == null) throw new NotFoundException();

        return customsClearanceOfPostalGoods;
    }

    /// <summary>
    ///     Update one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public async Task UpdateCustomsClearanceOfPostalGoods(
        CustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId,
        CustomsClearanceOfPostalGoodsUpdateInput updateDto
    )
    {
        var customsClearanceOfPostalGoods = updateDto.ToModel(uniqueId);

        _context.Entry(customsClearanceOfPostalGoods).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.CustomsClearanceOfPostalGoodsItems.Any(e =>
                    e.Id == customsClearanceOfPostalGoods.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
