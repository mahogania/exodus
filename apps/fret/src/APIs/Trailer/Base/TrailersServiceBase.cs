using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Fret.APIs.Extensions;
using Fret.Infrastructure;
using Fret.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Fret.APIs;

public abstract class TrailersServiceBase : ITrailersService
{
    protected readonly FretDbContext _context;

    public TrailersServiceBase(FretDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Remorque
    /// </summary>
    public async Task<Trailer> CreateTrailer(TrailerCreateInput createDto)
    {
        var trailer = new TrailerDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DateEtHeureDeModificationFinale = createDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = createDto.DateEtHeureDePremierEnregistrement,
            GabaritDeRemorque = createDto.GabaritDeRemorque,
            IdDuModificateurFinal = createDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            NDImmatriculationDuVHicule = createDto.NDImmatriculationDuVHicule,
            NDeChSsis = createDto.NDeChSsis,
            NDeSQuenceDeBl = createDto.NDeSQuenceDeBl,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                createDto.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            NumRoDeSRieDeLaRemorque = createDto.NumRoDeSRieDeLaRemorque,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            trailer.Id = createDto.Id;
        }

        _context.Trailers.Add(trailer);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TrailerDbModel>(trailer.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Remorque
    /// </summary>
    public async Task DeleteTrailer(TrailerWhereUniqueInput uniqueId)
    {
        var trailer = await _context.Trailers.FindAsync(uniqueId.Id);
        if (trailer == null)
        {
            throw new NotFoundException();
        }

        _context.Trailers.Remove(trailer);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Trailers
    /// </summary>
    public async Task<List<Trailer>> Trailers(TrailerFindManyArgs findManyArgs)
    {
        var trailers = await _context
            .Trailers.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return trailers.ConvertAll(trailer => trailer.ToDto());
    }

    /// <summary>
    /// Meta data about Remorque records
    /// </summary>
    public async Task<MetadataDto> TrailersMeta(TrailerFindManyArgs findManyArgs)
    {
        var count = await _context.Trailers.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Remorque
    /// </summary>
    public async Task<Trailer> Trailer(TrailerWhereUniqueInput uniqueId)
    {
        var trailers = await this.Trailers(
            new TrailerFindManyArgs { Where = new TrailerWhereInput { Id = uniqueId.Id } }
        );
        var trailer = trailers.FirstOrDefault();
        if (trailer == null)
        {
            throw new NotFoundException();
        }

        return trailer;
    }

    /// <summary>
    /// Update one Remorque
    /// </summary>
    public async Task UpdateTrailer(TrailerWhereUniqueInput uniqueId, TrailerUpdateInput updateDto)
    {
        var trailer = updateDto.ToModel(uniqueId);

        _context.Entry(trailer).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Trailers.Any(e => e.Id == trailer.Id))
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
