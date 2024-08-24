using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class TpdVehiclesServiceBase : ITpdVehiclesService
{
    protected readonly TravelerDbContext _context;

    public TpdVehiclesServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one TpdVehicle
    /// </summary>
    public async Task<TpdVehicle> CreateTpdVehicle(TpdVehicleCreateInput createDto)
    {
        var tpdVehicle = new TpdVehicleDbModel
        {
            ChassisNumber = createDto.ChassisNumber,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            EngineCapacity = createDto.EngineCapacity,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FirstRegistrationDate = createDto.FirstRegistrationDate,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            Gvw = createDto.Gvw,
            NumberOfSeats = createDto.NumberOfSeats,
            Payload = createDto.Payload,
            ProvisionalTpdNumber = createDto.ProvisionalTpdNumber,
            TpdVehicleBodyCode = createDto.TpdVehicleBodyCode,
            TpdVehicleBrandCode = createDto.TpdVehicleBrandCode,
            TpdVehicleColorCode = createDto.TpdVehicleColorCode,
            TpdVehicleEnergyCode = createDto.TpdVehicleEnergyCode,
            TpdVehicleGenreCode = createDto.TpdVehicleGenreCode,
            TpdVehicleTypeCode = createDto.TpdVehicleTypeCode,
            UpdatedAt = createDto.UpdatedAt,
            VehicleManufacturerCode = createDto.VehicleManufacturerCode,
            VehicleModelCode = createDto.VehicleModelCode,
            VehiclePower = createDto.VehiclePower,
            VehicleRegistrationNumber = createDto.VehicleRegistrationNumber
        };

        if (createDto.Id != null)
        {
            tpdVehicle.Id = createDto.Id;
        }
        if (createDto.GeneralTravelerInformationTpds != null)
        {
            tpdVehicle.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.TpdVehicles.Add(tpdVehicle);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TpdVehicleDbModel>(tpdVehicle.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one TpdVehicle
    /// </summary>
    public async Task DeleteTpdVehicle(TpdVehicleWhereUniqueInput uniqueId)
    {
        var tpdVehicle = await _context.TpdVehicles.FindAsync(uniqueId.Id);
        if (tpdVehicle == null)
        {
            throw new NotFoundException();
        }

        _context.TpdVehicles.Remove(tpdVehicle);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many TpdVehicles
    /// </summary>
    public async Task<List<TpdVehicle>> TpdVehicles(TpdVehicleFindManyArgs findManyArgs)
    {
        var tpdVehicles = await _context
            .TpdVehicles.Include(x => x.GeneralTravelerInformationTpds)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return tpdVehicles.ConvertAll(tpdVehicle => tpdVehicle.ToDto());
    }

    /// <summary>
    /// Meta data about TpdVehicle records
    /// </summary>
    public async Task<MetadataDto> TpdVehiclesMeta(TpdVehicleFindManyArgs findManyArgs)
    {
        var count = await _context.TpdVehicles.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one TpdVehicle
    /// </summary>
    public async Task<TpdVehicle> TpdVehicle(TpdVehicleWhereUniqueInput uniqueId)
    {
        var tpdVehicles = await this.TpdVehicles(
            new TpdVehicleFindManyArgs { Where = new TpdVehicleWhereInput { Id = uniqueId.Id } }
        );
        var tpdVehicle = tpdVehicles.FirstOrDefault();
        if (tpdVehicle == null)
        {
            throw new NotFoundException();
        }

        return tpdVehicle;
    }

    /// <summary>
    /// Update one TpdVehicle
    /// </summary>
    public async Task UpdateTpdVehicle(
        TpdVehicleWhereUniqueInput uniqueId,
        TpdVehicleUpdateInput updateDto
    )
    {
        var tpdVehicle = updateDto.ToModel(uniqueId);

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            tpdVehicle.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.Entry(tpdVehicle).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.TpdVehicles.Any(e => e.Id == tpdVehicle.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TpdVehicle
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        TpdVehicleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .TpdVehicles.Include(x => x.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(t =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (generalTravelerInformationTpds.Count == 0)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpdsToConnect = generalTravelerInformationTpds.Except(
            parent.GeneralTravelerInformationTpds
        );

        foreach (var generalTravelerInformationTpd in generalTravelerInformationTpdsToConnect)
        {
            parent.GeneralTravelerInformationTpds.Add(generalTravelerInformationTpd);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from TpdVehicle
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        TpdVehicleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .TpdVehicles.Include(x => x.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(t =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var generalTravelerInformationTpd in generalTravelerInformationTpds)
        {
            parent.GeneralTravelerInformationTpds?.Remove(generalTravelerInformationTpd);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for TpdVehicle
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        TpdVehicleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs tpdVehicleFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m => m.TpdVehicleId == uniqueId.Id)
            .ApplyWhere(tpdVehicleFindManyArgs.Where)
            .ApplySkip(tpdVehicleFindManyArgs.Skip)
            .ApplyTake(tpdVehicleFindManyArgs.Take)
            .ApplyOrderBy(tpdVehicleFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TpdVehicle
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        TpdVehicleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var tpdVehicle = await _context
            .TpdVehicles.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (tpdVehicle == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(a =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (generalTravelerInformationTpds.Count == 0)
        {
            throw new NotFoundException();
        }

        tpdVehicle.GeneralTravelerInformationTpds = generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }
}
