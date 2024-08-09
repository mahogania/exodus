using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IReimbursementsService
{
    /// <summary>
    /// Create one REIMBURSEMENT
    /// </summary>
    public Task<Reimbursement> CreateReimbursement(ReimbursementCreateInput reimbursement);

    /// <summary>
    /// Delete one REIMBURSEMENT
    /// </summary>
    public Task DeleteReimbursement(ReimbursementWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many REIMBURSEMENTS
    /// </summary>
    public Task<List<Reimbursement>> Reimbursements(ReimbursementFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about REIMBURSEMENT records
    /// </summary>
    public Task<MetadataDto> ReimbursementsMeta(ReimbursementFindManyArgs findManyArgs);

    /// <summary>
    /// Get one REIMBURSEMENT
    /// </summary>
    public Task<Reimbursement> Reimbursement(ReimbursementWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one REIMBURSEMENT
    /// </summary>
    public Task UpdateReimbursement(
        ReimbursementWhereUniqueInput uniqueId,
        ReimbursementUpdateInput updateDto
    );
}
