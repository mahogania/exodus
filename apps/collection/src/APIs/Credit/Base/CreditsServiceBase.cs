using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class CreditsServiceBase : ICreditsService
{
    protected readonly CollectionDbContext _context;

    public CreditsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one CREDIT
    /// </summary>
    public async Task<Credit> CreateCredit(CreditCreateInput createDto)
    {
        var credit = new CreditDbModel
        {
            AdjustmentDate = createDto.AdjustmentDate,
            AgencyCode = createDto.AgencyCode,
            AssignedAccountant = createDto.AssignedAccountant,
            AttachmentId = createDto.AttachmentId,
            AuthorizingOfficerDesignation = createDto.AuthorizingOfficerDesignation,
            AuthorizingOfficerQuality = createDto.AuthorizingOfficerQuality,
            BankAccountNo = createDto.BankAccountNo,
            CreatedAt = createDto.CreatedAt,
            CustomsNote = createDto.CustomsNote,
            DeclarantCode = createDto.DeclarantCode,
            DeclarationNo = createDto.DeclarationNo,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            GuaranteeAmount = createDto.GuaranteeAmount,
            GuaranteeClosedOn = createDto.GuaranteeClosedOn,
            GuaranteeClosureDate = createDto.GuaranteeClosureDate,
            GuaranteeIssuanceNo = createDto.GuaranteeIssuanceNo,
            GuaranteeNo = createDto.GuaranteeNo,
            GuaranteeTypeCode = createDto.GuaranteeTypeCode,
            GuaranteeValidityStatusCode = createDto.GuaranteeValidityStatusCode,
            GuarantorOrganizationCode = createDto.GuarantorOrganizationCode,
            GuarantorOrganizationName = createDto.GuarantorOrganizationName,
            OfficeCode = createDto.OfficeCode,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            RegisteringPersonId = createDto.RegisteringPersonId,
            RegistrationDate = createDto.RegistrationDate,
            RejectionReason = createDto.RejectionReason,
            RejectionReasonContent = createDto.RejectionReasonContent,
            RequestDate = createDto.RequestDate,
            RequestNo = createDto.RequestNo,
            ServiceCode = createDto.ServiceCode,
            TaxIdentificationNumber = createDto.TaxIdentificationNumber,
            UnknownField = createDto.UnknownField,
            UpdatedAt = createDto.UpdatedAt,
            ValidityEndDate = createDto.ValidityEndDate,
            ValidityStartDate = createDto.ValidityStartDate
        };

        if (createDto.Id != null) credit.Id = createDto.Id;

        _context.Credits.Add(credit);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CreditDbModel>(credit.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one CREDIT
    /// </summary>
    public async Task DeleteCredit(CreditWhereUniqueInput uniqueId)
    {
        var credit = await _context.Credits.FindAsync(uniqueId.Id);
        if (credit == null) throw new NotFoundException();

        _context.Credits.Remove(credit);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many CREDITS
    /// </summary>
    public async Task<List<Credit>> Credits(CreditFindManyArgs findManyArgs)
    {
        var credits = await _context
            .Credits.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return credits.ConvertAll(credit => credit.ToDto());
    }

    /// <summary>
    ///     Meta data about CREDIT records
    /// </summary>
    public async Task<MetadataDto> CreditsMeta(CreditFindManyArgs findManyArgs)
    {
        var count = await _context.Credits.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one CREDIT
    /// </summary>
    public async Task<Credit> Credit(CreditWhereUniqueInput uniqueId)
    {
        var credits = await Credits(
            new CreditFindManyArgs { Where = new CreditWhereInput { Id = uniqueId.Id } }
        );
        var credit = credits.FirstOrDefault();
        if (credit == null) throw new NotFoundException();

        return credit;
    }

    /// <summary>
    ///     Update one CREDIT
    /// </summary>
    public async Task UpdateCredit(CreditWhereUniqueInput uniqueId, CreditUpdateInput updateDto)
    {
        var credit = updateDto.ToModel(uniqueId);

        _context.Entry(credit).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Credits.Any(e => e.Id == credit.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
