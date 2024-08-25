using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IPaysPreferentielsService
{
    /// <summary>
    /// Create one PaysPreferentiel
    /// </summary>
    public Task<PaysPreferentiel> CreatePaysPreferentiel(
        PaysPreferentielCreateInput payspreferentiel
    );

    /// <summary>
    /// Delete one PaysPreferentiel
    /// </summary>
    public Task DeletePaysPreferentiel(PaysPreferentielWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many PaysPreferentiels
    /// </summary>
    public Task<List<PaysPreferentiel>> PaysPreferentiels(
        PaysPreferentielFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about PaysPreferentiel records
    /// </summary>
    public Task<MetadataDto> PaysPreferentielsMeta(PaysPreferentielFindManyArgs findManyArgs);

    /// <summary>
    /// Get one PaysPreferentiel
    /// </summary>
    public Task<PaysPreferentiel> PaysPreferentiel(PaysPreferentielWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one PaysPreferentiel
    /// </summary>
    public Task UpdatePaysPreferentiel(
        PaysPreferentielWhereUniqueInput uniqueId,
        PaysPreferentielUpdateInput updateDto
    );
}
