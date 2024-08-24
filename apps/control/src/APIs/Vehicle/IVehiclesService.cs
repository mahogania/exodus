using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IVehiclesService
{
    /// <summary>
    /// Create one Vehicle
    /// </summary>
    public Task<Vehicle> CreateVehicle(VehicleCreateInput vehicle);

    /// <summary>
    /// Delete one Vehicle
    /// </summary>
    public Task DeleteVehicle(VehicleWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many DETAILED DECLARATION VEHICLES
    /// </summary>
    public Task<List<Vehicle>> Vehicles(VehicleFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Vehicle records
    /// </summary>
    public Task<MetadataDto> VehiclesMeta(VehicleFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Vehicle
    /// </summary>
    public Task<Vehicle> Vehicle(VehicleWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Vehicle
    /// </summary>
    public Task UpdateVehicle(VehicleWhereUniqueInput uniqueId, VehicleUpdateInput updateDto);

    /// <summary>
    /// Get a Articles record for DETAILED DECLARATION VEHICLE
    /// </summary>
    public Task<Article> GetArticles(VehicleWhereUniqueInput uniqueId);
}
