using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class TemporaryAdmissionForPerfectionsServiceBase
    : ITemporaryAdmissionForPerfectionsService
{
    protected readonly ControlDbContext _context;

    public TemporaryAdmissionForPerfectionsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one TEMPORARY ADMISSION FOR PERFECTION
    /// </summary>
    public async Task<TemporaryAdmissionForPerfection> CreateTemporaryAdmissionForPerfection(
        TemporaryAdmissionForPerfectionCreateInput createDto
    )
    {
        var temporaryAdmissionForPerfection = new TemporaryAdmissionForPerfectionDbModel
        {
            ActivePerfectionRepairPerformedByThirdParty =
                createDto.ActivePerfectionRepairPerformedByThirdParty,
            Address = createDto.Address,
            ApcCode = createDto.ApcCode,
            Applicant = createDto.Applicant,
            ApplicantNature = createDto.ApplicantNature,
            CessionDecisionDeliveryDate = createDto.CessionDecisionDeliveryDate,
            CessionDecisionNumber = createDto.CessionDecisionNumber,
            CommerceRegistryNumber = createDto.CommerceRegistryNumber,
            ContributionRate = createDto.ContributionRate,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeletionOn = createDto.DeletionOn,
            DomiciliaryBankAddress = createDto.DomiciliaryBankAddress,
            DomiciliaryBankLegalName = createDto.DomiciliaryBankLegalName,
            EndDateOfRegimeAuthorization = createDto.EndDateOfRegimeAuthorization,
            EpcCode = createDto.EpcCode,
            EstablishmentAddress = createDto.EstablishmentAddress,
            ExportCustomsOffice = createDto.ExportCustomsOffice,
            ExportOperationPaymentMode = createDto.ExportOperationPaymentMode,
            FinalModifierSId = createDto.FinalModifierSId,
            FinishedProductWasteRate = createDto.FinishedProductWasteRate,
            FirstRecorderSId = createDto.FirstRecorderSId,
            ForeignOriginMaterialQuantitiesRateAcquiredOnNationalMarket =
                createDto.ForeignOriginMaterialQuantitiesRateAcquiredOnNationalMarket,
            GoodsFromAnotherRde = createDto.GoodsFromAnotherRde,
            ImportCustomsOffice = createDto.ImportCustomsOffice,
            ImportOperationFinancingMode = createDto.ImportOperationFinancingMode,
            ImportedMaterialQuantitiesRate = createDto.ImportedMaterialQuantitiesRate,
            ImportedPackagingQuantitiesRate = createDto.ImportedPackagingQuantitiesRate,
            LocalAddress = createDto.LocalAddress,
            LossRate = createDto.LossRate,
            NameAndLegalNameOfThirdParty = createDto.NameAndLegalNameOfThirdParty,
            NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepaired =
                createDto.NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepaired,
            NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepairedByThirdParty =
                createDto.NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepairedByThirdParty,
            NationalOriginMaterialQuantitiesRate = createDto.NationalOriginMaterialQuantitiesRate,
            NatureOfOperation = createDto.NatureOfOperation,
            NatureOfOperationPerformedByThirdParty =
                createDto.NatureOfOperationPerformedByThirdParty,
            Nif = createDto.Nif,
            NifStatus = createDto.NifStatus,
            NonRecoverableWasteRate = createDto.NonRecoverableWasteRate,
            PlannedTotalAmountForTransformationRepair =
                createDto.PlannedTotalAmountForTransformationRepair,
            RcStatus = createDto.RcStatus,
            RecoverableWasteRate = createDto.RecoverableWasteRate,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeAuthorizationNumber = createDto.RegimeAuthorizationNumber,
            RequestRegimeNumber = createDto.RequestRegimeNumber,
            RequestedActivePerfectionType = createDto.RequestedActivePerfectionType,
            RequestedAuthorizationType = createDto.RequestedAuthorizationType,
            RequestedEndDate = createDto.RequestedEndDate,
            RequestedStartDate = createDto.RequestedStartDate,
            StartDateOfRegimeAuthorization = createDto.StartDateOfRegimeAuthorization,
            TransferWithMaintenanceOfRegime = createDto.TransferWithMaintenanceOfRegime,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            temporaryAdmissionForPerfection.Id = createDto.Id;
        }

        _context.TemporaryAdmissionForPerfections.Add(temporaryAdmissionForPerfection);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TemporaryAdmissionForPerfectionDbModel>(
            temporaryAdmissionForPerfection.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one TEMPORARY ADMISSION FOR PERFECTION
    /// </summary>
    public async Task DeleteTemporaryAdmissionForPerfection(
        TemporaryAdmissionForPerfectionWhereUniqueInput uniqueId
    )
    {
        var temporaryAdmissionForPerfection =
            await _context.TemporaryAdmissionForPerfections.FindAsync(uniqueId.Id);
        if (temporaryAdmissionForPerfection == null)
        {
            throw new NotFoundException();
        }

        _context.TemporaryAdmissionForPerfections.Remove(temporaryAdmissionForPerfection);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many TEMPORARY ADMISSION FOR PERFECTIONS
    /// </summary>
    public async Task<List<TemporaryAdmissionForPerfection>> TemporaryAdmissionForPerfections(
        TemporaryAdmissionForPerfectionFindManyArgs findManyArgs
    )
    {
        var temporaryAdmissionForPerfections = await _context
            .TemporaryAdmissionForPerfections.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return temporaryAdmissionForPerfections.ConvertAll(temporaryAdmissionForPerfection =>
            temporaryAdmissionForPerfection.ToDto()
        );
    }

    /// <summary>
    /// Meta data about TEMPORARY ADMISSION FOR PERFECTION records
    /// </summary>
    public async Task<MetadataDto> TemporaryAdmissionForPerfectionsMeta(
        TemporaryAdmissionForPerfectionFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .TemporaryAdmissionForPerfections.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one TEMPORARY ADMISSION FOR PERFECTION
    /// </summary>
    public async Task<TemporaryAdmissionForPerfection> TemporaryAdmissionForPerfection(
        TemporaryAdmissionForPerfectionWhereUniqueInput uniqueId
    )
    {
        var temporaryAdmissionForPerfections = await this.TemporaryAdmissionForPerfections(
            new TemporaryAdmissionForPerfectionFindManyArgs
            {
                Where = new TemporaryAdmissionForPerfectionWhereInput { Id = uniqueId.Id }
            }
        );
        var temporaryAdmissionForPerfection = temporaryAdmissionForPerfections.FirstOrDefault();
        if (temporaryAdmissionForPerfection == null)
        {
            throw new NotFoundException();
        }

        return temporaryAdmissionForPerfection;
    }

    /// <summary>
    /// Update one TEMPORARY ADMISSION FOR PERFECTION
    /// </summary>
    public async Task UpdateTemporaryAdmissionForPerfection(
        TemporaryAdmissionForPerfectionWhereUniqueInput uniqueId,
        TemporaryAdmissionForPerfectionUpdateInput updateDto
    )
    {
        var temporaryAdmissionForPerfection = updateDto.ToModel(uniqueId);

        _context.Entry(temporaryAdmissionForPerfection).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.TemporaryAdmissionForPerfections.Any(e =>
                    e.Id == temporaryAdmissionForPerfection.Id
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
