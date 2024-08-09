using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Fret.APIs.Extensions;
using Fret.Infrastructure;
using Fret.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Fret.APIs;

public abstract class VehiclesServiceBase : IVehiclesService
{
    protected readonly FretDbContext _context;

    public VehiclesServiceBase(FretDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Vehicule
    /// </summary>
    public async Task<Vehicle> CreateVehicle(VehicleCreateInput createDto)
    {
        var vehicle = new VehicleDbModel
        {
            AnnEDeFabricationDeVHicule = createDto.AnnEDeFabricationDeVHicule,
            CodeDeFabricantDuVHicule = createDto.CodeDeFabricantDuVHicule,
            CodeDeModLeDuVHicule = createDto.CodeDeModLeDuVHicule,
            CreatedAt = createDto.CreatedAt,
            DateEtHeureDeModificationFinale = createDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = createDto.DateEtHeureDePremierEnregistrement,
            IdDuModificateurFinal = createDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            NDImmatriculationDuVHicule = createDto.NDImmatriculationDuVHicule,
            NDeChSsis = createDto.NDeChSsis,
            NDeSQuenceDeBl = createDto.NDeSQuenceDeBl,
            NombreDeCylindresDeMoteur = createDto.NombreDeCylindresDeMoteur,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                createDto.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            NumRoDeSQuenceDeVHicule = createDto.NumRoDeSQuenceDeVHicule,
            PoidsTotalEnCharge = createDto.PoidsTotalEnCharge,
            SuppressionOn = createDto.SuppressionOn,
            TypeDeVHicule = createDto.TypeDeVHicule,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            vehicle.Id = createDto.Id;
        }

        _context.Vehicles.Add(vehicle);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<VehicleDbModel>(vehicle.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Vehicule
    /// </summary>
    public async Task DeleteVehicle(VehicleWhereUniqueInput uniqueId)
    {
        var vehicle = await _context.Vehicles.FindAsync(uniqueId.Id);
        if (vehicle == null)
        {
            throw new NotFoundException();
        }

        _context.Vehicles.Remove(vehicle);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Vehicles
    /// </summary>
    public async Task<List<Vehicle>> Vehicles(VehicleFindManyArgs findManyArgs)
    {
        var vehicles = await _context
            .Vehicles.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return vehicles.ConvertAll(vehicle => vehicle.ToDto());
    }

    /// <summary>
    /// Meta data about Vehicule records
    /// </summary>
    public async Task<MetadataDto> VehiclesMeta(VehicleFindManyArgs findManyArgs)
    {
        var count = await _context.Vehicles.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Vehicule
    /// </summary>
    public async Task<Vehicle> Vehicle(VehicleWhereUniqueInput uniqueId)
    {
        var vehicles = await this.Vehicles(
            new VehicleFindManyArgs { Where = new VehicleWhereInput { Id = uniqueId.Id } }
        );
        var vehicle = vehicles.FirstOrDefault();
        if (vehicle == null)
        {
            throw new NotFoundException();
        }

        return vehicle;
    }

    /// <summary>
    /// Update one Vehicule
    /// </summary>
    public async Task UpdateVehicle(VehicleWhereUniqueInput uniqueId, VehicleUpdateInput updateDto)
    {
        var vehicle = updateDto.ToModel(uniqueId);

        _context.Entry(vehicle).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Vehicles.Any(e => e.Id == vehicle.Id))
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
