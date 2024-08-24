using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class RecourseRequestsExtensions
{
    public static RecourseRequest ToDto(this RecourseRequestDbModel model)
    {
        return new RecourseRequest
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            Journal = model.JournalId,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static RecourseRequestDbModel ToModel(
        this RecourseRequestUpdateInput updateDto,
        RecourseRequestWhereUniqueInput uniqueId
    )
    {
        var recourseRequest = new RecourseRequestDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            recourseRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.Journal != null)
        {
            recourseRequest.JournalId = updateDto.Journal;
        }
        if (updateDto.UpdatedAt != null)
        {
            recourseRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return recourseRequest;
    }
}
