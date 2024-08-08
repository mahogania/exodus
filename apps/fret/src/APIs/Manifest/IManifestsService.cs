using Fret.APIs.Common;
using Fret.APIs.Dtos;

namespace Fret.APIs;

public interface IManifestsService
{
    /// <summary>
    /// Create one Manifeste
    /// </summary>
    public Task<Manifest> CreateManifest(ManifestCreateInput manifest);

    /// <summary>
    /// Delete one Manifeste
    /// </summary>
    public Task DeleteManifest(ManifestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Manifests
    /// </summary>
    public Task<List<Manifest>> Manifests(ManifestFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Manifeste records
    /// </summary>
    public Task<MetadataDto> ManifestsMeta(ManifestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Manifeste
    /// </summary>
    public Task<Manifest> Manifest(ManifestWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Manifeste
    /// </summary>
    public Task UpdateManifest(ManifestWhereUniqueInput uniqueId, ManifestUpdateInput updateDto);
}
