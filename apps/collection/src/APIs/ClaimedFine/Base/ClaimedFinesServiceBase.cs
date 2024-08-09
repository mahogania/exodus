using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class ClaimedFinesServiceBase : IClaimedFinesService
{
    protected readonly CollectionDbContext _context;

    public ClaimedFinesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one CLAIMED FINE
    /// </summary>
    public async Task<ClaimedFine> CreateClaimedFine(ClaimedFineCreateInput createDto)
    {
        var claimedFine = new ClaimedFineDbModel
        {
            AcceptedByTaxpayerOn = createDto.AcceptedByTaxpayerOn,
            ApprovalId = createDto.ApprovalId,
            AttachedFileId = createDto.AttachedFileId,
            CreatedAt = createDto.CreatedAt,
            DeclarantCode = createDto.DeclarantCode,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FinancialOfficerName = createDto.FinancialOfficerName,
            FineAmount = createDto.FineAmount,
            FineAmountInEur = createDto.FineAmountInEur,
            FineAmountInUsd = createDto.FineAmountInUsd,
            FineImpositionRequestNumber = createDto.FineImpositionRequestNumber,
            FineRegistrationReasonContent = createDto.FineRegistrationReasonContent,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NotificationRequiredOn = createDto.NotificationRequiredOn,
            OfficeCode = createDto.OfficeCode,
            OpinionRegisteredByTaxpayerOn = createDto.OpinionRegisteredByTaxpayerOn,
            ReferenceDate = createDto.ReferenceDate,
            ReferenceNumber = createDto.ReferenceNumber,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = createDto.ReferenceNumberTypeName,
            RequestDate = createDto.RequestDate,
            RequestingPersonId = createDto.RequestingPersonId,
            ServiceCode = createDto.ServiceCode,
            TaxpayerAcceptanceMoment = createDto.TaxpayerAcceptanceMoment,
            TaxpayerIdentificationNumber = createDto.TaxpayerIdentificationNumber,
            TinCategoryCode = createDto.TinCategoryCode,
            TinCategoryName = createDto.TinCategoryName,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            claimedFine.Id = createDto.Id;
        }

        _context.ClaimedFines.Add(claimedFine);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ClaimedFineDbModel>(claimedFine.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one CLAIMED FINE
    /// </summary>
    public async Task DeleteClaimedFine(ClaimedFineWhereUniqueInput uniqueId)
    {
        var claimedFine = await _context.ClaimedFines.FindAsync(uniqueId.Id);
        if (claimedFine == null)
        {
            throw new NotFoundException();
        }

        _context.ClaimedFines.Remove(claimedFine);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many CLAIMED FINES
    /// </summary>
    public async Task<List<ClaimedFine>> ClaimedFines(ClaimedFineFindManyArgs findManyArgs)
    {
        var claimedFines = await _context
            .ClaimedFines.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return claimedFines.ConvertAll(claimedFine => claimedFine.ToDto());
    }

    /// <summary>
    /// Meta data about CLAIMED FINE records
    /// </summary>
    public async Task<MetadataDto> ClaimedFinesMeta(ClaimedFineFindManyArgs findManyArgs)
    {
        var count = await _context.ClaimedFines.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one CLAIMED FINE
    /// </summary>
    public async Task<ClaimedFine> ClaimedFine(ClaimedFineWhereUniqueInput uniqueId)
    {
        var claimedFines = await this.ClaimedFines(
            new ClaimedFineFindManyArgs { Where = new ClaimedFineWhereInput { Id = uniqueId.Id } }
        );
        var claimedFine = claimedFines.FirstOrDefault();
        if (claimedFine == null)
        {
            throw new NotFoundException();
        }

        return claimedFine;
    }

    /// <summary>
    /// Update one CLAIMED FINE
    /// </summary>
    public async Task UpdateClaimedFine(
        ClaimedFineWhereUniqueInput uniqueId,
        ClaimedFineUpdateInput updateDto
    )
    {
        var claimedFine = updateDto.ToModel(uniqueId);

        _context.Entry(claimedFine).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ClaimedFines.Any(e => e.Id == claimedFine.Id))
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
