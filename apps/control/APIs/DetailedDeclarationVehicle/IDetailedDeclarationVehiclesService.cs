using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDetailedDeclarationVehiclesService
{
    /// <summary>
    ///     Create one DETAILED DECLARATION VEHICLE
    /// </summary>
    public Task<DetailedDeclarationVehicle> CreateDetailedDeclarationVehicle(
        DetailedDeclarationVehicleCreateInput detaileddeclarationvehicle
    );

    /// <summary>
    ///     Delete one DETAILED DECLARATION VEHICLE
    /// </summary>
    public Task DeleteDetailedDeclarationVehicle(
        DetailedDeclarationVehicleWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many DETAILED DECLARATION VEHICLES
    /// </summary>
    public Task<List<DetailedDeclarationVehicle>> DetailedDeclarationVehicles(
        DetailedDeclarationVehicleFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about DETAILED DECLARATION VEHICLE records
    /// </summary>
    public Task<MetadataDto> DetailedDeclarationVehiclesMeta(
        DetailedDeclarationVehicleFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one DETAILED DECLARATION VEHICLE
    /// </summary>
    public Task<DetailedDeclarationVehicle> DetailedDeclarationVehicle(
        DetailedDeclarationVehicleWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one DETAILED DECLARATION VEHICLE
    /// </summary>
    public Task UpdateDetailedDeclarationVehicle(
        DetailedDeclarationVehicleWhereUniqueInput uniqueId,
        DetailedDeclarationVehicleUpdateInput updateDto
    );
}
