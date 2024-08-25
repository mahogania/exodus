using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class SimplifiedCustomsClearanceOfPostalParcelsItemsServiceBase
    : ISimplifiedCustomsClearanceOfPostalParcelsItemsService
{
    protected readonly ControlDbContext _context;

    public SimplifiedCustomsClearanceOfPostalParcelsItemsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    public async Task<SimplifiedCustomsClearanceOfPostalParcels> CreateSimplifiedCustomsClearanceOfPostalParcels(
        SimplifiedCustomsClearanceOfPostalParcelsCreateInput createDto
    )
    {
        var simplifiedCustomsClearanceOfPostalParcels =
            new SimplifiedCustomsClearanceOfPostalParcelsDbModel
            {
                AmountAndCurrencyCode = createDto.AmountAndCurrencyCode,
                ApplicationOfTheFreeTradeAgreementTariffOn =
                    createDto.ApplicationOfTheFreeTradeAgreementTariffOn,
                ArrivalDate = createDto.ArrivalDate,
                AttachedFileId = createDto.AttachedFileId,
                CodeOfPaymentMethod = createDto.CodeOfPaymentMethod,
                CodeOfThePostOfficeHandlingInternationalParcels =
                    createDto.CodeOfThePostOfficeHandlingInternationalParcels,
                CodeOfTypeOfArticlesSuspectedOfInfringingIntellectualPropertyRights =
                    createDto.CodeOfTypeOfArticlesSuspectedOfInfringingIntellectualPropertyRights,
                CodeOfTypeOfDestruction = createDto.CodeOfTypeOfDestruction,
                CodeOfTypeOfReturn = createDto.CodeOfTypeOfReturn,
                CommercialName = createDto.CommercialName,
                ContentsOfOthers = createDto.ContentsOfOthers,
                CountryOfDispatchCode = createDto.CountryOfDispatchCode,
                CreatedAt = createDto.CreatedAt,
                CustomsClearanceNumber = createDto.CustomsClearanceNumber,
                CustomsOfficeCode = createDto.CustomsOfficeCode,
                CustomsSimplifiedClearanceRequestNumber =
                    createDto.CustomsSimplifiedClearanceRequestNumber,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                DeclarantSCode = createDto.DeclarantSCode,
                DeclaredGoodsName = createDto.DeclaredGoodsName,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRecorderSId = createDto.FirstRecorderSId,
                GiftsOn = createDto.GiftsOn,
                GrossWeight = createDto.GrossWeight,
                NameOfThePostOfficeHandlingInternationalParcels =
                    createDto.NameOfThePostOfficeHandlingInternationalParcels,
                OthersOn = createDto.OthersOn,
                PersonalCustomsClearanceNumber = createDto.PersonalCustomsClearanceNumber,
                PersonalPurchaseOn = createDto.PersonalPurchaseOn,
                PostalParcelNumber = createDto.PostalParcelNumber,
                Quantity = createDto.Quantity,
                ReasonsForArticlesSuspectedOfInfringingIntellectualPropertyRights =
                    createDto.ReasonsForArticlesSuspectedOfInfringingIntellectualPropertyRights,
                RecipientSAddress = createDto.RecipientSAddress,
                RecipientSName = createDto.RecipientSName,
                RecipientSPhoneNumber = createDto.RecipientSPhoneNumber,
                RecipientSPostalCode = createDto.RecipientSPostalCode,
                ReintroductionOn = createDto.ReintroductionOn,
                RequestDate = createDto.RequestDate,
                ReturnOrDestructionOn = createDto.ReturnOrDestructionOn,
                SenderSName = createDto.SenderSName,
                Standards = createDto.Standards,
                StatusCodeOfProcessing = createDto.StatusCodeOfProcessing,
                SuppressionOn = createDto.SuppressionOn,
                UpdatedAt = createDto.UpdatedAt,
                ValueOfPostalParcels = createDto.ValueOfPostalParcels,
                Weight = createDto.Weight
            };

        if (createDto.Id != null) simplifiedCustomsClearanceOfPostalParcels.Id = createDto.Id;

        _context.SimplifiedCustomsClearanceOfPostalParcelsItems.Add(
            simplifiedCustomsClearanceOfPostalParcels
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<SimplifiedCustomsClearanceOfPostalParcelsDbModel>(
            simplifiedCustomsClearanceOfPostalParcels.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    public async Task DeleteSimplifiedCustomsClearanceOfPostalParcels(
        SimplifiedCustomsClearanceOfPostalParcelsWhereUniqueInput uniqueId
    )
    {
        var simplifiedCustomsClearanceOfPostalParcels =
            await _context.SimplifiedCustomsClearanceOfPostalParcelsItems.FindAsync(uniqueId.Id);
        if (simplifiedCustomsClearanceOfPostalParcels == null) throw new NotFoundException();

        _context.SimplifiedCustomsClearanceOfPostalParcelsItems.Remove(
            simplifiedCustomsClearanceOfPostalParcels
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELSItems
    /// </summary>
    public async Task<
        List<SimplifiedCustomsClearanceOfPostalParcels>
    > SimplifiedCustomsClearanceOfPostalParcelsItems(
        SimplifiedCustomsClearanceOfPostalParcelsFindManyArgs findManyArgs
    )
    {
        var simplifiedCustomsClearanceOfPostalParcelsItems = await _context
            .SimplifiedCustomsClearanceOfPostalParcelsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return simplifiedCustomsClearanceOfPostalParcelsItems.ConvertAll(
            simplifiedCustomsClearanceOfPostalParcels =>
                simplifiedCustomsClearanceOfPostalParcels.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS records
    /// </summary>
    public async Task<MetadataDto> SimplifiedCustomsClearanceOfPostalParcelsItemsMeta(
        SimplifiedCustomsClearanceOfPostalParcelsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .SimplifiedCustomsClearanceOfPostalParcelsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    public async Task<SimplifiedCustomsClearanceOfPostalParcels> SimplifiedCustomsClearanceOfPostalParcels(
        SimplifiedCustomsClearanceOfPostalParcelsWhereUniqueInput uniqueId
    )
    {
        var simplifiedCustomsClearanceOfPostalParcelsItems =
            await SimplifiedCustomsClearanceOfPostalParcelsItems(
                new SimplifiedCustomsClearanceOfPostalParcelsFindManyArgs
                {
                    Where = new SimplifiedCustomsClearanceOfPostalParcelsWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var simplifiedCustomsClearanceOfPostalParcels =
            simplifiedCustomsClearanceOfPostalParcelsItems.FirstOrDefault();
        if (simplifiedCustomsClearanceOfPostalParcels == null) throw new NotFoundException();

        return simplifiedCustomsClearanceOfPostalParcels;
    }

    /// <summary>
    ///     Update one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    public async Task UpdateSimplifiedCustomsClearanceOfPostalParcels(
        SimplifiedCustomsClearanceOfPostalParcelsWhereUniqueInput uniqueId,
        SimplifiedCustomsClearanceOfPostalParcelsUpdateInput updateDto
    )
    {
        var simplifiedCustomsClearanceOfPostalParcels = updateDto.ToModel(uniqueId);

        _context.Entry(simplifiedCustomsClearanceOfPostalParcels).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.SimplifiedCustomsClearanceOfPostalParcelsItems.Any(e =>
                    e.Id == simplifiedCustomsClearanceOfPostalParcels.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
