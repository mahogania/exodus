using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ITemporaryAdmissionOfVehiclesService
{
    /// <summary>
    /// Create one Temporary Admission Of Vehicle
    /// </summary>
    public Task<TemporaryAdmissionOfVehicle> CreateTemporaryAdmissionOfVehicle(
        TemporaryAdmissionOfVehicleCreateInput temporaryadmissionofvehicle
    );

    /// <summary>
    /// Delete one Temporary Admission Of Vehicle
    /// </summary>
    public Task DeleteTemporaryAdmissionOfVehicle(
        TemporaryAdmissionOfVehicleWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many TEMPORARY ADMISSION OF VEHICLES
    /// </summary>
    public Task<List<TemporaryAdmissionOfVehicle>> TemporaryAdmissionOfVehicles(
        TemporaryAdmissionOfVehicleFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Temporary Admission Of Vehicle records
    /// </summary>
    public Task<MetadataDto> TemporaryAdmissionOfVehiclesMeta(
        TemporaryAdmissionOfVehicleFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Temporary Admission Of Vehicle
    /// </summary>
    public Task<TemporaryAdmissionOfVehicle> TemporaryAdmissionOfVehicle(
        TemporaryAdmissionOfVehicleWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Temporary Admission Of Vehicle
    /// </summary>
    public Task UpdateTemporaryAdmissionOfVehicle(
        TemporaryAdmissionOfVehicleWhereUniqueInput uniqueId,
        TemporaryAdmissionOfVehicleUpdateInput updateDto
    );
}
