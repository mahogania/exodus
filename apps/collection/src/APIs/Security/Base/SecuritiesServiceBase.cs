using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class SecuritiesServiceBase : ISecuritiesService
{
    protected readonly CollectionDbContext _context;

    public SecuritiesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one SECURITY
    /// </summary>
    public async Task<Security> CreateSecurity(SecurityCreateInput createDto)
    {
        var security = new SecurityDbModel
        {
            AdjustmentDate = createDto.AdjustmentDate,
            AssignedAccountant = createDto.AssignedAccountant,
            AuthorizingOfficerSCapacity = createDto.AuthorizingOfficerSCapacity,
            AuthorizingOfficerSDesignation = createDto.AuthorizingOfficerSDesignation,
            BankAccountNumber = createDto.BankAccountNumber,
            BankBranchCode = createDto.BankBranchCode,
            BankCode = createDto.BankCode,
            CompanyAddress = createDto.CompanyAddress,
            CompanyName = createDto.CompanyName,
            CreatedAt = createDto.CreatedAt,
            CustomsNote = createDto.CustomsNote,
            DeclarationDate = createDto.DeclarationDate,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            GuarantorOrganizationCode = createDto.GuarantorOrganizationCode,
            GuarantorOrganizationName = createDto.GuarantorOrganizationName,
            OfficeCode = createDto.OfficeCode,
            PrincipalObligor = createDto.PrincipalObligor,
            RegisteringPersonId = createDto.RegisteringPersonId,
            RejectYesNo = createDto.RejectYesNo,
            RejectionReason = createDto.RejectionReason,
            RepresentativeSLastName = createDto.RepresentativeSLastName,
            RequestDate = createDto.RequestDate,
            RequestNumber = createDto.RequestNumber,
            SecurityAmount = createDto.SecurityAmount,
            SecurityClosureDate = createDto.SecurityClosureDate,
            SecurityIssuanceNumber = createDto.SecurityIssuanceNumber,
            SecurityReleaseCertificateIssuanceDate =
                createDto.SecurityReleaseCertificateIssuanceDate,
            SecurityTypeCode = createDto.SecurityTypeCode,
            SecurityValidityStatusCode = createDto.SecurityValidityStatusCode,
            ServiceCode = createDto.ServiceCode,
            SuspensionReason = createDto.SuspensionReason,
            TaxIdentificationNumber = createDto.TaxIdentificationNumber,
            UpdatedAt = createDto.UpdatedAt,
            ValidityEndDate = createDto.ValidityEndDate,
            ValidityStartDate = createDto.ValidityStartDate
        };

        if (createDto.Id != null) security.Id = createDto.Id;

        _context.Securities.Add(security);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<SecurityDbModel>(security.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one SECURITY
    /// </summary>
    public async Task DeleteSecurity(SecurityWhereUniqueInput uniqueId)
    {
        var security = await _context.Securities.FindAsync(uniqueId.Id);
        if (security == null) throw new NotFoundException();

        _context.Securities.Remove(security);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many SECURITIES
    /// </summary>
    public async Task<List<Security>> Securities(SecurityFindManyArgs findManyArgs)
    {
        var securities = await _context
            .Securities.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return securities.ConvertAll(security => security.ToDto());
    }

    /// <summary>
    ///     Meta data about SECURITY records
    /// </summary>
    public async Task<MetadataDto> SecuritiesMeta(SecurityFindManyArgs findManyArgs)
    {
        var count = await _context.Securities.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one SECURITY
    /// </summary>
    public async Task<Security> Security(SecurityWhereUniqueInput uniqueId)
    {
        var securities = await Securities(
            new SecurityFindManyArgs { Where = new SecurityWhereInput { Id = uniqueId.Id } }
        );
        var security = securities.FirstOrDefault();
        if (security == null) throw new NotFoundException();

        return security;
    }

    /// <summary>
    ///     Update one SECURITY
    /// </summary>
    public async Task UpdateSecurity(
        SecurityWhereUniqueInput uniqueId,
        SecurityUpdateInput updateDto
    )
    {
        var security = updateDto.ToModel(uniqueId);

        _context.Entry(security).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Securities.Any(e => e.Id == security.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
