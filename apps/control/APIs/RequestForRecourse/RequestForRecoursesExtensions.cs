using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class RequestForRecoursesExtensions
{
    public static RequestForRecourse ToDto(this RequestForRecourseDbModel model)
    {
        return new RequestForRecourse
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static RequestForRecourseDbModel ToModel(
        this RequestForRecourseUpdateInput updateDto,
        RequestForRecourseWhereUniqueInput uniqueId
    )
    {
        var requestForRecourse = new RequestForRecourseDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null) requestForRecourse.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) requestForRecourse.UpdatedAt = updateDto.UpdatedAt.Value;

        return requestForRecourse;
    }
}
