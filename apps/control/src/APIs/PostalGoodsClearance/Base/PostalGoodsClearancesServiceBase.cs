using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class PostalGoodsClearancesServiceBase : IPostalGoodsClearancesService
{
    protected readonly ControlDbContext _context;

    public PostalGoodsClearancesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Postal Goods Clearance
    /// </summary>
    public async Task<PostalGoodsClearance> CreatePostalGoodsClearance(
        PostalGoodsClearanceCreateInput createDto
    )
    {
        var postalGoodsClearance = new PostalGoodsClearanceDbModel
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

        if (createDto.Id != null)
        {
            postalGoodsClearance.Id = createDto.Id;
        }

        _context.PostalGoodsClearances.Add(postalGoodsClearance);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<PostalGoodsClearanceDbModel>(postalGoodsClearance.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Postal Goods Clearance
    /// </summary>
    public async Task DeletePostalGoodsClearance(PostalGoodsClearanceWhereUniqueInput uniqueId)
    {
        var postalGoodsClearance = await _context.PostalGoodsClearances.FindAsync(uniqueId.Id);
        if (postalGoodsClearance == null)
        {
            throw new NotFoundException();
        }

        _context.PostalGoodsClearances.Remove(postalGoodsClearance);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many CUSTOMS CLEARANCE OF POSTAL GOODSItems
    /// </summary>
    public async Task<List<PostalGoodsClearance>> PostalGoodsClearances(
        PostalGoodsClearanceFindManyArgs findManyArgs
    )
    {
        var postalGoodsClearances = await _context
            .PostalGoodsClearances.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return postalGoodsClearances.ConvertAll(postalGoodsClearance =>
            postalGoodsClearance.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Postal Goods Clearance records
    /// </summary>
    public async Task<MetadataDto> PostalGoodsClearancesMeta(
        PostalGoodsClearanceFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .PostalGoodsClearances.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Postal Goods Clearance
    /// </summary>
    public async Task<PostalGoodsClearance> PostalGoodsClearance(
        PostalGoodsClearanceWhereUniqueInput uniqueId
    )
    {
        var postalGoodsClearances = await this.PostalGoodsClearances(
            new PostalGoodsClearanceFindManyArgs
            {
                Where = new PostalGoodsClearanceWhereInput { Id = uniqueId.Id }
            }
        );
        var postalGoodsClearance = postalGoodsClearances.FirstOrDefault();
        if (postalGoodsClearance == null)
        {
            throw new NotFoundException();
        }

        return postalGoodsClearance;
    }

    /// <summary>
    /// Update one Postal Goods Clearance
    /// </summary>
    public async Task UpdatePostalGoodsClearance(
        PostalGoodsClearanceWhereUniqueInput uniqueId,
        PostalGoodsClearanceUpdateInput updateDto
    )
    {
        var postalGoodsClearance = updateDto.ToModel(uniqueId);

        _context.Entry(postalGoodsClearance).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.PostalGoodsClearances.Any(e => e.Id == postalGoodsClearance.Id))
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
