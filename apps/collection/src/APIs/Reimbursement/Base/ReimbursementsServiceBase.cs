using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class ReimbursementsServiceBase : IReimbursementsService
{
    protected readonly CollectionDbContext _context;

    public ReimbursementsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one REIMBURSEMENT
    /// </summary>
    public async Task<Reimbursement> CreateReimbursement(ReimbursementCreateInput createDto)
    {
        var reimbursement = new ReimbursementDbModel
        {
            AttachmentFileId = createDto.AttachmentFileId,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            OfficeCode = createDto.OfficeCode,
            ReceiverSOpinion = createDto.ReceiverSOpinion,
            RegistrationPersonIdentifier = createDto.RegistrationPersonIdentifier,
            ReimbursedAmount = createDto.ReimbursedAmount,
            ReimbursementDate = createDto.ReimbursementDate,
            ReimbursementDecisionType = createDto.ReimbursementDecisionType,
            ReimbursementNo = createDto.ReimbursementNo,
            ReimbursementReasonContent = createDto.ReimbursementReasonContent,
            ReimbursementRequestNo = createDto.ReimbursementRequestNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            reimbursement.Id = createDto.Id;
        }

        _context.Reimbursements.Add(reimbursement);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ReimbursementDbModel>(reimbursement.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one REIMBURSEMENT
    /// </summary>
    public async Task DeleteReimbursement(ReimbursementWhereUniqueInput uniqueId)
    {
        var reimbursement = await _context.Reimbursements.FindAsync(uniqueId.Id);
        if (reimbursement == null)
        {
            throw new NotFoundException();
        }

        _context.Reimbursements.Remove(reimbursement);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many REIMBURSEMENTS
    /// </summary>
    public async Task<List<Reimbursement>> Reimbursements(ReimbursementFindManyArgs findManyArgs)
    {
        var reimbursements = await _context
            .Reimbursements.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return reimbursements.ConvertAll(reimbursement => reimbursement.ToDto());
    }

    /// <summary>
    /// Meta data about REIMBURSEMENT records
    /// </summary>
    public async Task<MetadataDto> ReimbursementsMeta(ReimbursementFindManyArgs findManyArgs)
    {
        var count = await _context.Reimbursements.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one REIMBURSEMENT
    /// </summary>
    public async Task<Reimbursement> Reimbursement(ReimbursementWhereUniqueInput uniqueId)
    {
        var reimbursements = await this.Reimbursements(
            new ReimbursementFindManyArgs
            {
                Where = new ReimbursementWhereInput { Id = uniqueId.Id }
            }
        );
        var reimbursement = reimbursements.FirstOrDefault();
        if (reimbursement == null)
        {
            throw new NotFoundException();
        }

        return reimbursement;
    }

    /// <summary>
    /// Update one REIMBURSEMENT
    /// </summary>
    public async Task UpdateReimbursement(
        ReimbursementWhereUniqueInput uniqueId,
        ReimbursementUpdateInput updateDto
    )
    {
        var reimbursement = updateDto.ToModel(uniqueId);

        _context.Entry(reimbursement).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Reimbursements.Any(e => e.Id == reimbursement.Id))
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
