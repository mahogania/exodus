using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class DeclarationOfValueOfTheDetailedDeclarationCustomsItemsServiceBase
    : IDeclarationOfValueOfTheDetailedDeclarationCustomsItemsService
{
    protected readonly ClreDbContext _context;

    public DeclarationOfValueOfTheDetailedDeclarationCustomsItemsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<DeclarationOfValueOfTheDetailedDeclarationCustoms> CreateDeclarationOfValueOfTheDetailedDeclarationCustoms(
        DeclarationOfValueOfTheDetailedDeclarationCustomsCreateInput createDto
    )
    {
        var declarationOfValueOfTheDetailedDeclarationCustoms =
            new DeclarationOfValueOfTheDetailedDeclarationCustomsDbModel
            {
                AdditionalCostOfMediationAmount = createDto.AdditionalCostOfMediationAmount,
                AdditionalCostOfOtherFeesForLoadingAtTheImportPort =
                    createDto.AdditionalCostOfOtherFeesForLoadingAtTheImportPort,
                AdditionalCostOfOtherFeesForTechnologicalDesign =
                    createDto.AdditionalCostOfOtherFeesForTechnologicalDesign,
                AdditionalCostOfOtherToolFees = createDto.AdditionalCostOfOtherToolFees,
                AdditionalCostOfPurchaseCommissionOn =
                    createDto.AdditionalCostOfPurchaseCommissionOn,
                AdditionalCostOfSalesCommissionOn = createDto.AdditionalCostOfSalesCommissionOn,
                AdditionalCostOfTheAmountOfFreightFromTheImportPort =
                    createDto.AdditionalCostOfTheAmountOfFreightFromTheImportPort,
                AdditionalCostOfTheAmountOfInsuranceFromTheImportPort =
                    createDto.AdditionalCostOfTheAmountOfInsuranceFromTheImportPort,
                AdditionalCostOfTheCostOfComponentsOfTheMaterials =
                    createDto.AdditionalCostOfTheCostOfComponentsOfTheMaterials,
                AdditionalCostOfTheCostOfConsumableGoods =
                    createDto.AdditionalCostOfTheCostOfConsumableGoods,
                AdditionalCostOfTheCostOfPackagesAndContainers =
                    createDto.AdditionalCostOfTheCostOfPackagesAndContainers,
                AdditionalCostOfTheCostOfProcessing = createDto.AdditionalCostOfTheCostOfProcessing,
                AdditionalCostOfTheLicenseFee = createDto.AdditionalCostOfTheLicenseFee,
                AdditionalCostOfTheSellerSProfitAmount =
                    createDto.AdditionalCostOfTheSellerSProfitAmount,
                AdditionalCostOfTransportCost = createDto.AdditionalCostOfTransportCost,
                BaseForCalculatingIndirectAmount = createDto.BaseForCalculatingIndirectAmount,
                BaseForCalculatingTotalAmount = createDto.BaseForCalculatingTotalAmount,
                BaseForCalculatingTransactionalValue =
                    createDto.BaseForCalculatingTransactionalValue,
                BuyerSIdentificationNumber = createDto.BuyerSIdentificationNumber,
                ComplementaryObservation = createDto.ComplementaryObservation,
                ContractConclusionDate = createDto.ContractConclusionDate,
                ContractNumber = createDto.ContractNumber,
                CreatedAt = createDto.CreatedAt,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                DateOfIssuanceOfTheInvoice = createDto.DateOfIssuanceOfTheInvoice,
                DateOfIssuanceOfTheOfficialLetterOfPreliminaryDecision =
                    createDto.DateOfIssuanceOfTheOfficialLetterOfPreliminaryDecision,
                DeclarantSName = createDto.DeclarantSName,
                DeclarationDate = createDto.DeclarationDate,
                DeclaredStatisticalValue = createDto.DeclaredStatisticalValue,
                DeductedAmountOfCustomsDutiesOfTheExportingCountry =
                    createDto.DeductedAmountOfCustomsDutiesOfTheExportingCountry,
                DeductedOtherFees = createDto.DeductedOtherFees,
                DeductedOtherServices = createDto.DeductedOtherServices,
                DeductedTotalAmount = createDto.DeductedTotalAmount,
                DeductedTransportCost = createDto.DeductedTransportCost,
                DeliveryConditionCode = createDto.DeliveryConditionCode,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRecorderSId = createDto.FirstRecorderSId,
                InvoiceNumber = createDto.InvoiceNumber,
                NumberOfTheOfficialLetterOfPreliminaryDecision =
                    createDto.NumberOfTheOfficialLetterOfPreliminaryDecision,
                OtherExplanations = createDto.OtherExplanations,
                PlaceOfDeclarationName = createDto.PlaceOfDeclarationName,
                Question_1On = createDto.Question_1On,
                Question_2On = createDto.Question_2On,
                Question_3On = createDto.Question_3On,
                Question_4On = createDto.Question_4On,
                Question_5On = createDto.Question_5On,
                Question_6On = createDto.Question_6On,
                Question_7On = createDto.Question_7On,
                Question_8On = createDto.Question_8On,
                RectificationFrequency = createDto.RectificationFrequency,
                ReferenceNumber = createDto.ReferenceNumber,
                SellerSIdentificationNumber = createDto.SellerSIdentificationNumber,
                SpecifyTheNatureOfTheRestrictions = createDto.SpecifyTheNatureOfTheRestrictions,
                SuppressionOn = createDto.SuppressionOn,
                TotalDeductedAmountOfAdditionalCosts =
                    createDto.TotalDeductedAmountOfAdditionalCosts,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            declarationOfValueOfTheDetailedDeclarationCustoms.Id = createDto.Id;
        }

        _context.DeclarationOfValueOfTheDetailedDeclarationCustomsItems.Add(
            declarationOfValueOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();

        var result =
            await _context.FindAsync<DeclarationOfValueOfTheDetailedDeclarationCustomsDbModel>(
                declarationOfValueOfTheDetailedDeclarationCustoms.Id
            );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task DeleteDeclarationOfValueOfTheDetailedDeclarationCustoms(
        DeclarationOfValueOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var declarationOfValueOfTheDetailedDeclarationCustoms =
            await _context.DeclarationOfValueOfTheDetailedDeclarationCustomsItems.FindAsync(
                uniqueId.Id
            );
        if (declarationOfValueOfTheDetailedDeclarationCustoms == null)
        {
            throw new NotFoundException();
        }

        _context.DeclarationOfValueOfTheDetailedDeclarationCustomsItems.Remove(
            declarationOfValueOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public async Task<
        List<DeclarationOfValueOfTheDetailedDeclarationCustoms>
    > DeclarationOfValueOfTheDetailedDeclarationCustomsItems(
        DeclarationOfValueOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var declarationOfValueOfTheDetailedDeclarationCustomsItems = await _context
            .DeclarationOfValueOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return declarationOfValueOfTheDetailedDeclarationCustomsItems.ConvertAll(
            declarationOfValueOfTheDetailedDeclarationCustoms =>
                declarationOfValueOfTheDetailedDeclarationCustoms.ToDto()
        );
    }

    /// <summary>
    /// Meta data about DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public async Task<MetadataDto> DeclarationOfValueOfTheDetailedDeclarationCustomsItemsMeta(
        DeclarationOfValueOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DeclarationOfValueOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<DeclarationOfValueOfTheDetailedDeclarationCustoms> DeclarationOfValueOfTheDetailedDeclarationCustoms(
        DeclarationOfValueOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var declarationOfValueOfTheDetailedDeclarationCustomsItems =
            await this.DeclarationOfValueOfTheDetailedDeclarationCustomsItems(
                new DeclarationOfValueOfTheDetailedDeclarationCustomsFindManyArgs
                {
                    Where = new DeclarationOfValueOfTheDetailedDeclarationCustomsWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var declarationOfValueOfTheDetailedDeclarationCustoms =
            declarationOfValueOfTheDetailedDeclarationCustomsItems.FirstOrDefault();
        if (declarationOfValueOfTheDetailedDeclarationCustoms == null)
        {
            throw new NotFoundException();
        }

        return declarationOfValueOfTheDetailedDeclarationCustoms;
    }

    /// <summary>
    /// Update one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task UpdateDeclarationOfValueOfTheDetailedDeclarationCustoms(
        DeclarationOfValueOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        DeclarationOfValueOfTheDetailedDeclarationCustomsUpdateInput updateDto
    )
    {
        var declarationOfValueOfTheDetailedDeclarationCustoms = updateDto.ToModel(uniqueId);

        _context.Entry(declarationOfValueOfTheDetailedDeclarationCustoms).State =
            EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DeclarationOfValueOfTheDetailedDeclarationCustomsItems.Any(e =>
                    e.Id == declarationOfValueOfTheDetailedDeclarationCustoms.Id
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
