using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface ITpdVehiclesService
{
    /// <summary>
    /// Create one TpdVehicle
    /// </summary>
    public Task<TpdVehicle> CreateTpdVehicle(TpdVehicleCreateInput tpdvehicle);

    /// <summary>
    /// Delete one TpdVehicle
    /// </summary>
    public Task DeleteTpdVehicle(TpdVehicleWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many TpdVehicles
    /// </summary>
    public Task<List<TpdVehicle>> TpdVehicles(TpdVehicleFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about TpdVehicle records
    /// </summary>
    public Task<MetadataDto> TpdVehiclesMeta(TpdVehicleFindManyArgs findManyArgs);

    /// <summary>
    /// Get one TpdVehicle
    /// </summary>
    public Task<TpdVehicle> TpdVehicle(TpdVehicleWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one TpdVehicle
    /// </summary>
    public Task UpdateTpdVehicle(
        TpdVehicleWhereUniqueInput uniqueId,
        TpdVehicleUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TpdVehicle
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        TpdVehicleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from TpdVehicle
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        TpdVehicleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for TpdVehicle
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        TpdVehicleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TpdVehicle
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        TpdVehicleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );
}
