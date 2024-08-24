using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class PostalParcelSimplifiedClearancesServiceBase
    : IPostalParcelSimplifiedClearancesService
{
    protected readonly ControlDbContext _context;

    public PostalParcelSimplifiedClearancesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Postal Parcel Simplified Clearance
    /// </summary>
    public async Task<PostalParcelSimplifiedClearance> CreatePostalParcelSimplifiedClearance(
        PostalParcelSimplifiedClearanceCreateInput createDto
    )
    {
        var postalParcelSimplifiedClearance = new PostalParcelSimplifiedClearanceDbModel
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

        if (createDto.Id != null)
        {
            postalParcelSimplifiedClearance.Id = createDto.Id;
        }

        _context.PostalParcelSimplifiedClearances.Add(postalParcelSimplifiedClearance);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<PostalParcelSimplifiedClearanceDbModel>(
            postalParcelSimplifiedClearance.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Postal Parcel Simplified Clearance
    /// </summary>
    public async Task DeletePostalParcelSimplifiedClearance(
        PostalParcelSimplifiedClearanceWhereUniqueInput uniqueId
    )
    {
        var postalParcelSimplifiedClearance =
            await _context.PostalParcelSimplifiedClearances.FindAsync(uniqueId.Id);
        if (postalParcelSimplifiedClearance == null)
        {
            throw new NotFoundException();
        }

        _context.PostalParcelSimplifiedClearances.Remove(postalParcelSimplifiedClearance);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELSItems
    /// </summary>
    public async Task<List<PostalParcelSimplifiedClearance>> PostalParcelSimplifiedClearances(
        PostalParcelSimplifiedClearanceFindManyArgs findManyArgs
    )
    {
        var postalParcelSimplifiedClearances = await _context
            .PostalParcelSimplifiedClearances.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return postalParcelSimplifiedClearances.ConvertAll(postalParcelSimplifiedClearance =>
            postalParcelSimplifiedClearance.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Postal Parcel Simplified Clearance records
    /// </summary>
    public async Task<MetadataDto> PostalParcelSimplifiedClearancesMeta(
        PostalParcelSimplifiedClearanceFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .PostalParcelSimplifiedClearances.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Postal Parcel Simplified Clearance
    /// </summary>
    public async Task<PostalParcelSimplifiedClearance> PostalParcelSimplifiedClearance(
        PostalParcelSimplifiedClearanceWhereUniqueInput uniqueId
    )
    {
        var postalParcelSimplifiedClearances = await this.PostalParcelSimplifiedClearances(
            new PostalParcelSimplifiedClearanceFindManyArgs
            {
                Where = new PostalParcelSimplifiedClearanceWhereInput { Id = uniqueId.Id }
            }
        );
        var postalParcelSimplifiedClearance = postalParcelSimplifiedClearances.FirstOrDefault();
        if (postalParcelSimplifiedClearance == null)
        {
            throw new NotFoundException();
        }

        return postalParcelSimplifiedClearance;
    }

    /// <summary>
    /// Update one Postal Parcel Simplified Clearance
    /// </summary>
    public async Task UpdatePostalParcelSimplifiedClearance(
        PostalParcelSimplifiedClearanceWhereUniqueInput uniqueId,
        PostalParcelSimplifiedClearanceUpdateInput updateDto
    )
    {
        var postalParcelSimplifiedClearance = updateDto.ToModel(uniqueId);

        _context.Entry(postalParcelSimplifiedClearance).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.PostalParcelSimplifiedClearances.Any(e =>
                    e.Id == postalParcelSimplifiedClearance.Id
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
