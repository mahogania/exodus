using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ITemporaryAdmissionForPerfectionsService
{
    /// <summary>
    /// Create one Temporary Admission For Perfection
    /// </summary>
    public Task<TemporaryAdmissionForPerfection> CreateTemporaryAdmissionForPerfection(
        TemporaryAdmissionForPerfectionCreateInput temporaryadmissionforperfection
    );

    /// <summary>
    /// Delete one Temporary Admission For Perfection
    /// </summary>
    public Task DeleteTemporaryAdmissionForPerfection(
        TemporaryAdmissionForPerfectionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many TEMPORARY ADMISSION FOR PERFECTIONS
    /// </summary>
    public Task<List<TemporaryAdmissionForPerfection>> TemporaryAdmissionForPerfections(
        TemporaryAdmissionForPerfectionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Temporary Admission For Perfection records
    /// </summary>
    public Task<MetadataDto> TemporaryAdmissionForPerfectionsMeta(
        TemporaryAdmissionForPerfectionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Temporary Admission For Perfection
    /// </summary>
    public Task<TemporaryAdmissionForPerfection> TemporaryAdmissionForPerfection(
        TemporaryAdmissionForPerfectionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Temporary Admission For Perfection
    /// </summary>
    public Task UpdateTemporaryAdmissionForPerfection(
        TemporaryAdmissionForPerfectionWhereUniqueInput uniqueId,
        TemporaryAdmissionForPerfectionUpdateInput updateDto
    );
}
