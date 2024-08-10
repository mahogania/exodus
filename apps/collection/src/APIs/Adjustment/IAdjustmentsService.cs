using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IAdjustmentsService
{
    /// <summary>
    ///     Create one ADJUSTMENT
    /// </summary>
    public Task<Adjustment> CreateAdjustment(AdjustmentCreateInput adjustment);

    /// <summary>
    ///     Delete one ADJUSTMENT
    /// </summary>
    public Task DeleteAdjustment(AdjustmentWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many ADJUSTMENTS
    /// </summary>
    public Task<List<Adjustment>> Adjustments(AdjustmentFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about ADJUSTMENT records
    /// </summary>
    public Task<MetadataDto> AdjustmentsMeta(AdjustmentFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one ADJUSTMENT
    /// </summary>
    public Task<Adjustment> Adjustment(AdjustmentWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one ADJUSTMENT
    /// </summary>
    public Task UpdateAdjustment(
        AdjustmentWhereUniqueInput uniqueId,
        AdjustmentUpdateInput updateDto
    );
}
