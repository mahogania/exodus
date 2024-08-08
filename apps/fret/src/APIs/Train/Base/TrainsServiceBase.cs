using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Fret.APIs.Extensions;
using Fret.Infrastructure;
using Fret.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Fret.APIs;

public abstract class TrainsServiceBase : ITrainsService
{
    protected readonly FretDbContext _context;

    public TrainsServiceBase(FretDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Train
    /// </summary>
    public async Task<Train> CreateTrain(TrainCreateInput createDto)
    {
        var train = new TrainDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DateEtHeureDeModificationFinale = createDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = createDto.DateEtHeureDePremierEnregistrement,
            IdDuModificateurFinal = createDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            NDeSQuenceDeBl = createDto.NDeSQuenceDeBl,
            NDeWagon = createDto.NDeWagon,
            NEnregistrementDuTrain = createDto.NEnregistrementDuTrain,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                createDto.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            NumRoDeSRieDuTrain = createDto.NumRoDeSRieDuTrain,
            SuppressionOn = createDto.SuppressionOn,
            TypeDeWagon = createDto.TypeDeWagon,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            train.Id = createDto.Id;
        }

        _context.Trains.Add(train);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TrainDbModel>(train.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Train
    /// </summary>
    public async Task DeleteTrain(TrainWhereUniqueInput uniqueId)
    {
        var train = await _context.Trains.FindAsync(uniqueId.Id);
        if (train == null)
        {
            throw new NotFoundException();
        }

        _context.Trains.Remove(train);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Trains
    /// </summary>
    public async Task<List<Train>> Trains(TrainFindManyArgs findManyArgs)
    {
        var trains = await _context
            .Trains.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return trains.ConvertAll(train => train.ToDto());
    }

    /// <summary>
    /// Meta data about Train records
    /// </summary>
    public async Task<MetadataDto> TrainsMeta(TrainFindManyArgs findManyArgs)
    {
        var count = await _context.Trains.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Train
    /// </summary>
    public async Task<Train> Train(TrainWhereUniqueInput uniqueId)
    {
        var trains = await this.Trains(
            new TrainFindManyArgs { Where = new TrainWhereInput { Id = uniqueId.Id } }
        );
        var train = trains.FirstOrDefault();
        if (train == null)
        {
            throw new NotFoundException();
        }

        return train;
    }

    /// <summary>
    /// Update one Train
    /// </summary>
    public async Task UpdateTrain(TrainWhereUniqueInput uniqueId, TrainUpdateInput updateDto)
    {
        var train = updateDto.ToModel(uniqueId);

        _context.Entry(train).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Trains.Any(e => e.Id == train.Id))
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
