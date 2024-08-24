using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IItinerariesService
{
    /// <summary>
    /// Create one Itinerary
    /// </summary>
    public Task<Itinerary> CreateItinerary(ItineraryCreateInput itinerary);

    /// <summary>
    /// Delete one Itinerary
    /// </summary>
    public Task DeleteItinerary(ItineraryWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many TEXT ZONES FOR SPECIFYING THE ITIRENARY
    /// </summary>
    public Task<List<Itinerary>> Itineraries(ItineraryFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Itinerary records
    /// </summary>
    public Task<MetadataDto> ItinerariesMeta(ItineraryFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Itinerary
    /// </summary>
    public Task<Itinerary> Itinerary(ItineraryWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Itinerary
    /// </summary>
    public Task UpdateItinerary(ItineraryWhereUniqueInput uniqueId, ItineraryUpdateInput updateDto);
}
