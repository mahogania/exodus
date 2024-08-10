using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ExpressCustomsClearanceDetailsItemsServiceBase
    : IExpressCustomsClearanceDetailsItemsService
{
    protected readonly ControlDbContext _context;

    public ExpressCustomsClearanceDetailsItemsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one EXPRESS CUSTOMS CLEARANCE DETAILS
    /// </summary>
    public async Task<ExpressCustomsClearanceDetails> CreateExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsCreateInput createDto
    )
    {
        var expressCustomsClearanceDetails = new ExpressCustomsClearanceDetailsDbModel
        {
            BarcodeContent = createDto.BarcodeContent,
            BarcodeTransmissionDateAndTime = createDto.BarcodeTransmissionDateAndTime,
            CarrierCode = createDto.CarrierCode,
            CommercialDenomination = createDto.CommercialDenomination,
            CreatedAt = createDto.CreatedAt,
            CustomsClearanceCode = createDto.CustomsClearanceCode,
            CustomsNote = createDto.CustomsNote,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            ECommercialWebsite = createDto.ECommercialWebsite,
            ElectronicCommercialEnterpriseCertificationNumber =
                createDto.ElectronicCommercialEnterpriseCertificationNumber,
            ExpressCustomsClearanceRequestNumber = createDto.ExpressCustomsClearanceRequestNumber,
            ExpressCustomsClearanceTypeCode = createDto.ExpressCustomsClearanceTypeCode,
            ExpressOperatorCode = createDto.ExpressOperatorCode,
            FinalModifierSId = createDto.FinalModifierSId,
            GoodsValue = createDto.GoodsValue,
            HouseBlNumber = createDto.HouseBlNumber,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            MasterBlNumber = createDto.MasterBlNumber,
            OperationType = createDto.OperationType,
            OrdinaryCustomsClearanceOn = createDto.OrdinaryCustomsClearanceOn,
            PackageQuantity = createDto.PackageQuantity,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            PurposeTypeCode = createDto.PurposeTypeCode,
            Quantity = createDto.Quantity,
            RecipientSAddress = createDto.RecipientSAddress,
            RecipientSIdentificationCode = createDto.RecipientSIdentificationCode,
            RecipientSName = createDto.RecipientSName,
            RecipientSPhoneNumber = createDto.RecipientSPhoneNumber,
            RecipientSPostalCode = createDto.RecipientSPostalCode,
            SenderSAddress = createDto.SenderSAddress,
            SenderSName = createDto.SenderSName,
            SenderSPhoneNumber = createDto.SenderSPhoneNumber,
            SequenceNumber = createDto.SequenceNumber,
            ShCode = createDto.ShCode,
            ShippingCountryCode = createDto.ShippingCountryCode,
            SimpleCustomsDutyAmount = createDto.SimpleCustomsDutyAmount,
            SimplifiedCustomsClearanceOn = createDto.SimplifiedCustomsClearanceOn,
            Standards = createDto.Standards,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt,
            Weight = createDto.Weight
        };

        if (createDto.Id != null) expressCustomsClearanceDetails.Id = createDto.Id;

        _context.ExpressCustomsClearanceDetailsItems.Add(expressCustomsClearanceDetails);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ExpressCustomsClearanceDetailsDbModel>(
            expressCustomsClearanceDetails.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one EXPRESS CUSTOMS CLEARANCE DETAILS
    /// </summary>
    public async Task DeleteExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId
    )
    {
        var expressCustomsClearanceDetails =
            await _context.ExpressCustomsClearanceDetailsItems.FindAsync(uniqueId.Id);
        if (expressCustomsClearanceDetails == null) throw new NotFoundException();

        _context.ExpressCustomsClearanceDetailsItems.Remove(expressCustomsClearanceDetails);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many EXPRESS CUSTOMS CLEARANCE DETAILSItems
    /// </summary>
    public async Task<List<ExpressCustomsClearanceDetails>> ExpressCustomsClearanceDetailsItems(
        ExpressCustomsClearanceDetailsFindManyArgs findManyArgs
    )
    {
        var expressCustomsClearanceDetailsItems = await _context
            .ExpressCustomsClearanceDetailsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return expressCustomsClearanceDetailsItems.ConvertAll(expressCustomsClearanceDetails =>
            expressCustomsClearanceDetails.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about EXPRESS CUSTOMS CLEARANCE DETAILS records
    /// </summary>
    public async Task<MetadataDto> ExpressCustomsClearanceDetailsItemsMeta(
        ExpressCustomsClearanceDetailsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ExpressCustomsClearanceDetailsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one EXPRESS CUSTOMS CLEARANCE DETAILS
    /// </summary>
    public async Task<ExpressCustomsClearanceDetails> ExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId
    )
    {
        var expressCustomsClearanceDetailsItems = await ExpressCustomsClearanceDetailsItems(
            new ExpressCustomsClearanceDetailsFindManyArgs
            {
                Where = new ExpressCustomsClearanceDetailsWhereInput { Id = uniqueId.Id }
            }
        );
        var expressCustomsClearanceDetails = expressCustomsClearanceDetailsItems.FirstOrDefault();
        if (expressCustomsClearanceDetails == null) throw new NotFoundException();

        return expressCustomsClearanceDetails;
    }

    /// <summary>
    ///     Update one EXPRESS CUSTOMS CLEARANCE DETAILS
    /// </summary>
    public async Task UpdateExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId,
        ExpressCustomsClearanceDetailsUpdateInput updateDto
    )
    {
        var expressCustomsClearanceDetails = updateDto.ToModel(uniqueId);

        _context.Entry(expressCustomsClearanceDetails).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ExpressCustomsClearanceDetailsItems.Any(e =>
                    e.Id == expressCustomsClearanceDetails.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
