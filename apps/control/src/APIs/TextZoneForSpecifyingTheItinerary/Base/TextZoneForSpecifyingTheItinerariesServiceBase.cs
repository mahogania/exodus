using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class TextZoneForSpecifyingTheItinerariesServiceBase
    : ITextZoneForSpecifyingTheItinerariesService
{
    protected readonly ClreDbContext _context;

    public TextZoneForSpecifyingTheItinerariesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    public async Task<TextZoneForSpecifyingTheItinerary> CreateTextZoneForSpecifyingTheItinerary(
        TextZoneForSpecifyingTheItineraryCreateInput createDto
    )
    {
        var textZoneForSpecifyingTheItinerary = new TextZoneForSpecifyingTheItineraryDbModel
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
            textZoneForSpecifyingTheItinerary.Id = createDto.Id;
        }

        _context.TextZoneForSpecifyingTheItineraries.Add(textZoneForSpecifyingTheItinerary);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TextZoneForSpecifyingTheItineraryDbModel>(
            textZoneForSpecifyingTheItinerary.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    public async Task DeleteTextZoneForSpecifyingTheItinerary(
        TextZoneForSpecifyingTheItineraryWhereUniqueInput uniqueId
    )
    {
        var textZoneForSpecifyingTheItinerary =
            await _context.TextZoneForSpecifyingTheItineraries.FindAsync(uniqueId.Id);
        if (textZoneForSpecifyingTheItinerary == null)
        {
            throw new NotFoundException();
        }

        _context.TextZoneForSpecifyingTheItineraries.Remove(textZoneForSpecifyingTheItinerary);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Text zone for specifying the itineraries
    /// </summary>
    public async Task<List<TextZoneForSpecifyingTheItinerary>> TextZoneForSpecifyingTheItineraries(
        TextZoneForSpecifyingTheItineraryFindManyArgs findManyArgs
    )
    {
        var textZoneForSpecifyingTheItineraries = await _context
            .TextZoneForSpecifyingTheItineraries.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return textZoneForSpecifyingTheItineraries.ConvertAll(textZoneForSpecifyingTheItinerary =>
            textZoneForSpecifyingTheItinerary.ToDto()
        );
    }

    /// <summary>
    /// Meta data about TEXT ZONE FOR SPECIFYING THE ITIRENARY records
    /// </summary>
    public async Task<MetadataDto> TextZoneForSpecifyingTheItinerariesMeta(
        TextZoneForSpecifyingTheItineraryFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .TextZoneForSpecifyingTheItineraries.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    public async Task<TextZoneForSpecifyingTheItinerary> TextZoneForSpecifyingTheItinerary(
        TextZoneForSpecifyingTheItineraryWhereUniqueInput uniqueId
    )
    {
        var textZoneForSpecifyingTheItineraries = await this.TextZoneForSpecifyingTheItineraries(
            new TextZoneForSpecifyingTheItineraryFindManyArgs
            {
                Where = new TextZoneForSpecifyingTheItineraryWhereInput { Id = uniqueId.Id }
            }
        );
        var textZoneForSpecifyingTheItinerary =
            textZoneForSpecifyingTheItineraries.FirstOrDefault();
        if (textZoneForSpecifyingTheItinerary == null)
        {
            throw new NotFoundException();
        }

        return textZoneForSpecifyingTheItinerary;
    }

    /// <summary>
    /// Update one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    public async Task UpdateTextZoneForSpecifyingTheItinerary(
        TextZoneForSpecifyingTheItineraryWhereUniqueInput uniqueId,
        TextZoneForSpecifyingTheItineraryUpdateInput updateDto
    )
    {
        var textZoneForSpecifyingTheItinerary = updateDto.ToModel(uniqueId);

        _context.Entry(textZoneForSpecifyingTheItinerary).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.TextZoneForSpecifyingTheItineraries.Any(e =>
                    e.Id == textZoneForSpecifyingTheItinerary.Id
                )
            )
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
