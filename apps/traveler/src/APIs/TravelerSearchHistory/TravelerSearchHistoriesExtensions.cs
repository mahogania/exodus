using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class TravelerSearchHistoriesExtensions
{
    public static TravelerSearchHistory ToDto(this TravelerSearchHistoryDbModel model)
    {
        return new TravelerSearchHistory
        {
            CreatedAt = model.CreatedAt,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static TravelerSearchHistoryDbModel ToModel(
        this TravelerSearchHistoryUpdateInput updateDto,
        TravelerSearchHistoryWhereUniqueInput uniqueId
    )
    {
        var travelerSearchHistory = new TravelerSearchHistoryDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            travelerSearchHistory.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            travelerSearchHistory.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return travelerSearchHistory;
    }
}
