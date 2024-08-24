using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IOriginDeterminingInformationsService
{
    /// <summary>
    /// Create one Origin Determining Information
    /// </summary>
    public Task<OriginDeterminingInformation> CreateOriginDeterminingInformation(
        OriginDeterminingInformationCreateInput origindetermininginformation
    );

    /// <summary>
    /// Delete one Origin Determining Information
    /// </summary>
    public Task DeleteOriginDeterminingInformation(
        OriginDeterminingInformationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many INFORMATIONS FOR DETERMINING ORIGIN
    /// </summary>
    public Task<List<OriginDeterminingInformation>> OriginDeterminingInformations(
        OriginDeterminingInformationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Origin Determining Information records
    /// </summary>
    public Task<MetadataDto> OriginDeterminingInformationsMeta(
        OriginDeterminingInformationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Origin Determining Information
    /// </summary>
    public Task<OriginDeterminingInformation> OriginDeterminingInformation(
        OriginDeterminingInformationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Origin Determining Information
    /// </summary>
    public Task UpdateOriginDeterminingInformation(
        OriginDeterminingInformationWhereUniqueInput uniqueId,
        OriginDeterminingInformationUpdateInput updateDto
    );
}
