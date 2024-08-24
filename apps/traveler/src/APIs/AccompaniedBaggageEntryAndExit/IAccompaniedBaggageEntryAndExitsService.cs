using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface IAccompaniedBaggageEntryAndExitsService
{
    /// <summary>
    /// Create one AccompaniedBaggageEntryAndExit
    /// </summary>
    public Task<AccompaniedBaggageEntryAndExit> CreateAccompaniedBaggageEntryAndExit(
        AccompaniedBaggageEntryAndExitCreateInput accompaniedbaggageentryandexit
    );

    /// <summary>
    /// Delete one AccompaniedBaggageEntryAndExit
    /// </summary>
    public Task DeleteAccompaniedBaggageEntryAndExit(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many AccompaniedBaggageEntryAndExits
    /// </summary>
    public Task<List<AccompaniedBaggageEntryAndExit>> AccompaniedBaggageEntryAndExits(
        AccompaniedBaggageEntryAndExitFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about AccompaniedBaggageEntryAndExit records
    /// </summary>
    public Task<MetadataDto> AccompaniedBaggageEntryAndExitsMeta(
        AccompaniedBaggageEntryAndExitFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one AccompaniedBaggageEntryAndExit
    /// </summary>
    public Task<AccompaniedBaggageEntryAndExit> AccompaniedBaggageEntryAndExit(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one AccompaniedBaggageEntryAndExit
    /// </summary>
    public Task UpdateAccompaniedBaggageEntryAndExit(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
        AccompaniedBaggageEntryAndExitUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to AccompaniedBaggageEntryAndExit
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from AccompaniedBaggageEntryAndExit
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for AccompaniedBaggageEntryAndExit
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for AccompaniedBaggageEntryAndExit
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );
}
