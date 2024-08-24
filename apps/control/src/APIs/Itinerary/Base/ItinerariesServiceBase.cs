using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ItinerariesServiceBase : IItinerariesService
{
    protected readonly ControlDbContext _context;

    public ItinerariesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Itinerary
    /// </summary>
    public async Task<Itinerary> CreateItinerary(ItineraryCreateInput createDto)
    {
        var itinerary = new ItineraryDbModel
        {
            CityName = createDto.CityName,
            CountryCode = createDto.CountryCode,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DepartureDestinationCode = createDto.DepartureDestinationCode,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            SequenceNumber = createDto.SequenceNumber,
            SuppressionOn = createDto.SuppressionOn,
            TirRegistrationNumber = createDto.TirRegistrationNumber,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            itinerary.Id = createDto.Id;
        }

        _context.Itineraries.Add(itinerary);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ItineraryDbModel>(itinerary.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Itinerary
    /// </summary>
    public async Task DeleteItinerary(ItineraryWhereUniqueInput uniqueId)
    {
        var itinerary = await _context.Itineraries.FindAsync(uniqueId.Id);
        if (itinerary == null)
        {
            throw new NotFoundException();
        }

        _context.Itineraries.Remove(itinerary);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many TEXT ZONES FOR SPECIFYING THE ITIRENARY
    /// </summary>
    public async Task<List<Itinerary>> Itineraries(ItineraryFindManyArgs findManyArgs)
    {
        var itineraries = await _context
            .Itineraries.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return itineraries.ConvertAll(itinerary => itinerary.ToDto());
    }

    /// <summary>
    /// Meta data about Itinerary records
    /// </summary>
    public async Task<MetadataDto> ItinerariesMeta(ItineraryFindManyArgs findManyArgs)
    {
        var count = await _context.Itineraries.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Itinerary
    /// </summary>
    public async Task<Itinerary> Itinerary(ItineraryWhereUniqueInput uniqueId)
    {
        var itineraries = await this.Itineraries(
            new ItineraryFindManyArgs { Where = new ItineraryWhereInput { Id = uniqueId.Id } }
        );
        var itinerary = itineraries.FirstOrDefault();
        if (itinerary == null)
        {
            throw new NotFoundException();
        }

        return itinerary;
    }

    /// <summary>
    /// Update one Itinerary
    /// </summary>
    public async Task UpdateItinerary(
        ItineraryWhereUniqueInput uniqueId,
        ItineraryUpdateInput updateDto
    )
    {
        var itinerary = updateDto.ToModel(uniqueId);

        _context.Entry(itinerary).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Itineraries.Any(e => e.Id == itinerary.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }
}
