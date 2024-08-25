using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IValeurBoursieresService
{
    /// <summary>
    /// Create one ValeurBoursiere
    /// </summary>
    public Task<ValeurBoursiere> CreateValeurBoursiere(ValeurBoursiereCreateInput valeurboursiere);

    /// <summary>
    /// Delete one ValeurBoursiere
    /// </summary>
    public Task DeleteValeurBoursiere(ValeurBoursiereWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many ValeurBoursieres
    /// </summary>
    public Task<List<ValeurBoursiere>> ValeurBoursieres(ValeurBoursiereFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about ValeurBoursiere records
    /// </summary>
    public Task<MetadataDto> ValeurBoursieresMeta(ValeurBoursiereFindManyArgs findManyArgs);

    /// <summary>
    /// Get one ValeurBoursiere
    /// </summary>
    public Task<ValeurBoursiere> ValeurBoursiere(ValeurBoursiereWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one ValeurBoursiere
    /// </summary>
    public Task UpdateValeurBoursiere(
        ValeurBoursiereWhereUniqueInput uniqueId,
        ValeurBoursiereUpdateInput updateDto
    );
}
