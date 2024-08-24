using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ValueDeclarationsServiceBase : IValueDeclarationsService
{
    protected readonly ControlDbContext _context;

    public ValueDeclarationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Value Declaration
    /// </summary>
    public async Task<ValueDeclaration> CreateValueDeclaration(
        ValueDeclarationCreateInput createDto
    )
    {
        var valueDeclaration = new ValueDeclarationDbModel
        {
            AdditionalCostOfMediationAmount = createDto.AdditionalCostOfMediationAmount,
            AdditionalCostOfOtherFeesForLoadingAtTheImportPort =
                createDto.AdditionalCostOfOtherFeesForLoadingAtTheImportPort,
            AdditionalCostOfOtherFeesForTechnologicalDesign =
                createDto.AdditionalCostOfOtherFeesForTechnologicalDesign,
            AdditionalCostOfOtherToolFees = createDto.AdditionalCostOfOtherToolFees,
            AdditionalCostOfPurchaseCommissionOn = createDto.AdditionalCostOfPurchaseCommissionOn,
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
            BaseForCalculatingTransactionalValue = createDto.BaseForCalculatingTransactionalValue,
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
            TotalDeductedAmountOfAdditionalCosts = createDto.TotalDeductedAmountOfAdditionalCosts,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            valueDeclaration.Id = createDto.Id;
        }
        if (createDto.CommonDetailedDeclarations != null)
        {
            valueDeclaration.CommonDetailedDeclarations = await _context
                .CommonDetailedDeclarations.Where(commonDetailedDeclaration =>
                    createDto.CommonDetailedDeclarations.Id == commonDetailedDeclaration.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.ValueDeclarations.Add(valueDeclaration);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ValueDeclarationDbModel>(valueDeclaration.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Value Declaration
    /// </summary>
    public async Task DeleteValueDeclaration(ValueDeclarationWhereUniqueInput uniqueId)
    {
        var valueDeclaration = await _context.ValueDeclarations.FindAsync(uniqueId.Id);
        if (valueDeclaration == null)
        {
            throw new NotFoundException();
        }

        _context.ValueDeclarations.Remove(valueDeclaration);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public async Task<List<ValueDeclaration>> ValueDeclarations(
        ValueDeclarationFindManyArgs findManyArgs
    )
    {
        var valueDeclarations = await _context
            .ValueDeclarations.Include(x => x.CommonDetailedDeclarations)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return valueDeclarations.ConvertAll(valueDeclaration => valueDeclaration.ToDto());
    }

    /// <summary>
    /// Meta data about Value Declaration records
    /// </summary>
    public async Task<MetadataDto> ValueDeclarationsMeta(ValueDeclarationFindManyArgs findManyArgs)
    {
        var count = await _context.ValueDeclarations.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Value Declaration
    /// </summary>
    public async Task<ValueDeclaration> ValueDeclaration(ValueDeclarationWhereUniqueInput uniqueId)
    {
        var valueDeclarations = await this.ValueDeclarations(
            new ValueDeclarationFindManyArgs
            {
                Where = new ValueDeclarationWhereInput { Id = uniqueId.Id }
            }
        );
        var valueDeclaration = valueDeclarations.FirstOrDefault();
        if (valueDeclaration == null)
        {
            throw new NotFoundException();
        }

        return valueDeclaration;
    }

    /// <summary>
    /// Update one Value Declaration
    /// </summary>
    public async Task UpdateValueDeclaration(
        ValueDeclarationWhereUniqueInput uniqueId,
        ValueDeclarationUpdateInput updateDto
    )
    {
        var valueDeclaration = updateDto.ToModel(uniqueId);

        _context.Entry(valueDeclaration).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ValueDeclarations.Any(e => e.Id == valueDeclaration.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Get a COMMON DETAILED DECLARATIONS record for DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<CommonDetailedDeclaration> GetCommonDetailedDeclarations(
        ValueDeclarationWhereUniqueInput uniqueId
    )
    {
        var valueDeclaration = await _context
            .ValueDeclarations.Where(valueDeclaration => valueDeclaration.Id == uniqueId.Id)
            .Include(valueDeclaration => valueDeclaration.CommonDetailedDeclarations)
            .FirstOrDefaultAsync();
        if (valueDeclaration == null)
        {
            throw new NotFoundException();
        }
        return valueDeclaration.CommonDetailedDeclarations.ToDto();
    }
}
