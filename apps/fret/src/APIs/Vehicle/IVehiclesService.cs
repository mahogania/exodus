using Fret.APIs.Common;
using Fret.APIs.Dtos;

namespace Fret.APIs;

public interface IVehiclesService
{
    /// <summary>
    /// Create one Vehicule
    /// </summary>
    public Task<Vehicle> CreateVehicle(VehicleCreateInput vehicle);

    /// <summary>
    /// Delete one Vehicule
    /// </summary>
    public Task DeleteVehicle(VehicleWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Vehicles
    /// </summary>
    public Task<List<Vehicle>> Vehicles(VehicleFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Vehicule records
    /// </summary>
    public Task<MetadataDto> VehiclesMeta(VehicleFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Vehicule
    /// </summary>
    public Task<Vehicle> Vehicle(VehicleWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Vehicule
    /// </summary>
    public Task UpdateVehicle(VehicleWhereUniqueInput uniqueId, VehicleUpdateInput updateDto);
}
