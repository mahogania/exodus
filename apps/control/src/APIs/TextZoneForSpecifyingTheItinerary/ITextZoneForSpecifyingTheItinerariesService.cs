using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ITextZoneForSpecifyingTheItinerariesService
{
    /// <summary>
    /// Create one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    public Task<TextZoneForSpecifyingTheItinerary> CreateTextZoneForSpecifyingTheItinerary(
        TextZoneForSpecifyingTheItineraryCreateInput textzoneforspecifyingtheitinerary
    );

    /// <summary>
    /// Delete one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    public Task DeleteTextZoneForSpecifyingTheItinerary(
        TextZoneForSpecifyingTheItineraryWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Text zone for specifying the itineraries
    /// </summary>
    public Task<List<TextZoneForSpecifyingTheItinerary>> TextZoneForSpecifyingTheItineraries(
        TextZoneForSpecifyingTheItineraryFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about TEXT ZONE FOR SPECIFYING THE ITIRENARY records
    /// </summary>
    public Task<MetadataDto> TextZoneForSpecifyingTheItinerariesMeta(
        TextZoneForSpecifyingTheItineraryFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    public Task<TextZoneForSpecifyingTheItinerary> TextZoneForSpecifyingTheItinerary(
        TextZoneForSpecifyingTheItineraryWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    public Task UpdateTextZoneForSpecifyingTheItinerary(
        TextZoneForSpecifyingTheItineraryWhereUniqueInput uniqueId,
        TextZoneForSpecifyingTheItineraryUpdateInput updateDto
    );
}
