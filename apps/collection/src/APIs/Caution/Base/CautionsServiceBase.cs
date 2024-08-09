using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class CautionsServiceBase : ICautionsService
{
    protected readonly CollectionDbContext _context;

    public CautionsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one CAUTION
    /// </summary>
    public async Task<Caution> CreateCaution(CautionCreateInput createDto)
    {
        var caution = new CautionDbModel
        {
            AdjustmentDate = createDto.AdjustmentDate,
            AssigningAccountant = createDto.AssigningAccountant,
            AttachedFileId = createDto.AttachedFileId,
            BankAccountNumber = createDto.BankAccountNumber,
            BankAgencyCode = createDto.BankAgencyCode,
            BankCode = createDto.BankCode,
            CautionAmount = createDto.CautionAmount,
            CautionClosureDate = createDto.CautionClosureDate,
            CautionDeliveryNumber = createDto.CautionDeliveryNumber,
            CautionNumber = createDto.CautionNumber,
            CautionTypeCode = createDto.CautionTypeCode,
            CautionValidityEndDate = createDto.CautionValidityEndDate,
            CautionValidityStartDate = createDto.CautionValidityStartDate,
            CautionValidityStatusCode = createDto.CautionValidityStatusCode,
            CompanyAddress = createDto.CompanyAddress,
            CompanyName = createDto.CompanyName,
            CreatedAt = createDto.CreatedAt,
            CustomsNote = createDto.CustomsNote,
            DateOfCautionReleaseCertificateDelivery =
                createDto.DateOfCautionReleaseCertificateDelivery,
            DeclarantCode = createDto.DeclarantCode,
            DeclarationDate = createDto.DeclarationDate,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            GuarantorOrganizationCode = createDto.GuarantorOrganizationCode,
            GuarantorOrganizationName = createDto.GuarantorOrganizationName,
            OfficeCode = createDto.OfficeCode,
            OrderGiverDesignation = createDto.OrderGiverDesignation,
            OrderGiverQuality = createDto.OrderGiverQuality,
            PersonInChargeOfCautionReleaseCertificateDeliveryCode =
                createDto.PersonInChargeOfCautionReleaseCertificateDeliveryCode,
            PersonRegisteringId = createDto.PersonRegisteringId,
            PrincipalObligated = createDto.PrincipalObligated,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            RejectYesNo = createDto.RejectYesNo,
            RejectionReason = createDto.RejectionReason,
            RepresentativeLastName = createDto.RepresentativeLastName,
            RequestDate = createDto.RequestDate,
            RequestNumber = createDto.RequestNumber,
            ServiceCode = createDto.ServiceCode,
            SuspensionReason = createDto.SuspensionReason,
            TaxIdentificationNumber = createDto.TaxIdentificationNumber,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            caution.Id = createDto.Id;
        }

        _context.Cautions.Add(caution);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CautionDbModel>(caution.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one CAUTION
    /// </summary>
    public async Task DeleteCaution(CautionWhereUniqueInput uniqueId)
    {
        var caution = await _context.Cautions.FindAsync(uniqueId.Id);
        if (caution == null)
        {
            throw new NotFoundException();
        }

        _context.Cautions.Remove(caution);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many CAUTIONS
    /// </summary>
    public async Task<List<Caution>> Cautions(CautionFindManyArgs findManyArgs)
    {
        var cautions = await _context
            .Cautions.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return cautions.ConvertAll(caution => caution.ToDto());
    }

    /// <summary>
    /// Meta data about CAUTION records
    /// </summary>
    public async Task<MetadataDto> CautionsMeta(CautionFindManyArgs findManyArgs)
    {
        var count = await _context.Cautions.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one CAUTION
    /// </summary>
    public async Task<Caution> Caution(CautionWhereUniqueInput uniqueId)
    {
        var cautions = await this.Cautions(
            new CautionFindManyArgs { Where = new CautionWhereInput { Id = uniqueId.Id } }
        );
        var caution = cautions.FirstOrDefault();
        if (caution == null)
        {
            throw new NotFoundException();
        }

        return caution;
    }

    /// <summary>
    /// Update one CAUTION
    /// </summary>
    public async Task UpdateCaution(CautionWhereUniqueInput uniqueId, CautionUpdateInput updateDto)
    {
        var caution = updateDto.ToModel(uniqueId);

        _context.Entry(caution).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Cautions.Any(e => e.Id == caution.Id))
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
