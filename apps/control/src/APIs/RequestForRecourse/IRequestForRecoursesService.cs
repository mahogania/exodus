using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IRequestForRecoursesService
{
    /// <summary>
    /// Create one REQUEST FOR RECOURSE
    /// </summary>
    public Task<RequestForRecourse> CreateRequestForRecourse(
        RequestForRecourseCreateInput requestforrecourse
    );

    /// <summary>
    /// Delete one REQUEST FOR RECOURSE
    /// </summary>
    public Task DeleteRequestForRecourse(RequestForRecourseWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many REQUEST FOR RECOURSES
    /// </summary>
    public Task<List<RequestForRecourse>> RequestForRecourses(
        RequestForRecourseFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about REQUEST FOR RECOURSE records
    /// </summary>
    public Task<MetadataDto> RequestForRecoursesMeta(RequestForRecourseFindManyArgs findManyArgs);

    /// <summary>
    /// Get one REQUEST FOR RECOURSE
    /// </summary>
    public Task<RequestForRecourse> RequestForRecourse(RequestForRecourseWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one REQUEST FOR RECOURSE
    /// </summary>
    public Task UpdateRequestForRecourse(
        RequestForRecourseWhereUniqueInput uniqueId,
        RequestForRecourseUpdateInput updateDto
    );
}
