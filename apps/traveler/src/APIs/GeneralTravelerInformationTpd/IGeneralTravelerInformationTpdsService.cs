using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface IGeneralTravelerInformationTpdsService
{
    /// <summary>
    /// Create one GeneralTravelerInformationTpd
    /// </summary>
    public Task<GeneralTravelerInformationTpd> CreateGeneralTravelerInformationTpd(
        GeneralTravelerInformationTpdCreateInput generaltravelerinformationtpd
    );

    /// <summary>
    /// Delete one GeneralTravelerInformationTpd
    /// </summary>
    public Task DeleteGeneralTravelerInformationTpd(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many GeneralTravelerInformationTpds
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> GeneralTravelerInformationTpds(
        GeneralTravelerInformationTpdFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about GeneralTravelerInformationTpd records
    /// </summary>
    public Task<MetadataDto> GeneralTravelerInformationTpdsMeta(
        GeneralTravelerInformationTpdFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one GeneralTravelerInformationTpd
    /// </summary>
    public Task<GeneralTravelerInformationTpd> GeneralTravelerInformationTpd(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one GeneralTravelerInformationTpd
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpd(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdUpdateInput updateDto
    );

    /// <summary>
    /// Get a Accompanied Baggage Entry and Exit record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<AccompaniedBaggageEntryAndExit> GetAccompaniedBaggageEntryAndExit(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Get a Appeal record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<Appeal> GetAppeal(GeneralTravelerInformationTpdWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a Baggage Control Article record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<BaggageControlArticle> GetBaggageControlArticle(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Get a Exit Voucher record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<ExitVoucher> GetExitVoucher(GeneralTravelerInformationTpdWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a General Bond Note record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<GeneralBondNote> GetGeneralBondNote(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Get a Import Declaration record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<ImportDeclaration> GetImportDeclaration(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Get a Inspector Rating Modification History record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<InspectorRatingModificationHistory> GetInspectorRatingModificationHistory(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Get a TPD Control record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<TpdControl> GetTpdControl(GeneralTravelerInformationTpdWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a TPD Entry and Exit History record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<TpdEntryAndExitHistory> GetTpdEntryAndExitHistory(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Get a TPD Vehicle record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<TpdVehicle> GetTpdVehicle(GeneralTravelerInformationTpdWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a Traveler Search History record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<TravelerSearchHistory> GetTravelerSearchHistory(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Get a Travelers Articles Entry Exit record for GeneralTravelerInformationTpd
    /// </summary>
    public Task<TravelersArticlesEntryExit> GetTravelersArticlesEntryExit(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    );
}
