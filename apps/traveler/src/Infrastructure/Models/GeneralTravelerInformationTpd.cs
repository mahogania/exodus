using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("GeneralTravelerInformationTpds")]
public class GeneralTravelerInformationTpdDbModel
{
    public string? AccompaniedBaggageEntryAndExitId { get; set; }

    [ForeignKey(nameof(AccompaniedBaggageEntryAndExitId))]
    public AccompaniedBaggageEntryAndExitDbModel? AccompaniedBaggageEntryAndExit { get; set; } =
        null;

    public string? AppealId { get; set; }

    [ForeignKey(nameof(AppealId))]
    public AppealDbModel? Appeal { get; set; } = null;

    public string? BaggageControlArticleId { get; set; }

    [ForeignKey(nameof(BaggageControlArticleId))]
    public BaggageControlArticleDbModel? BaggageControlArticle { get; set; } = null;

    [StringLength(1000)]
    public string? CommanderNationalityCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? DriverAddress { get; set; }

    [StringLength(1000)]
    public string? DriverDateOfBirth { get; set; }

    [StringLength(1000)]
    public string? DriverFatherFullName { get; set; }

    [StringLength(1000)]
    public string? DriverFirstName { get; set; }

    [StringLength(1000)]
    public string? DriverForeignAddress { get; set; }

    [StringLength(1000)]
    public string? DriverLastName { get; set; }

    [StringLength(1000)]
    public string? DriverMotherFullName { get; set; }

    [StringLength(1000)]
    public string? DriverOccupation { get; set; }

    [StringLength(1000)]
    public string? DriverPassportIssuanceDate { get; set; }

    [StringLength(1000)]
    public string? DriverPassportIssuancePlace { get; set; }

    [StringLength(1000)]
    public string? DriverPassportNumber { get; set; }

    [StringLength(1000)]
    public string? DriverPlaceOfBirth { get; set; }

    [StringLength(1000)]
    public string? DriverTypeCode { get; set; }

    [StringLength(1000)]
    public string? DriverZipCode { get; set; }

    public string? ExitVoucherId { get; set; }

    [ForeignKey(nameof(ExitVoucherId))]
    public ExitVoucherDbModel? ExitVoucher { get; set; } = null;

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? GeneralBondNoteId { get; set; }

    [ForeignKey(nameof(GeneralBondNoteId))]
    public GeneralBondNoteDbModel? GeneralBondNote { get; set; } = null;

    [Key()]
    [Required()]
    public string Id { get; set; }

    public string? ImportDeclarationId { get; set; }

    [ForeignKey(nameof(ImportDeclarationId))]
    public ImportDeclarationDbModel? ImportDeclaration { get; set; } = null;

    public string? InspectorRatingModificationHistoryId { get; set; }

    [ForeignKey(nameof(InspectorRatingModificationHistoryId))]
    public InspectorRatingModificationHistoryDbModel? InspectorRatingModificationHistory { get; set; } =
        null;

    [StringLength(1000)]
    public string? OwnerAddress { get; set; }

    [StringLength(1000)]
    public string? OwnerCountryCode { get; set; }

    [StringLength(1000)]
    public string? OwnerDateOfBirth { get; set; }

    [StringLength(1000)]
    public string? OwnerFatherFullName { get; set; }

    [StringLength(1000)]
    public string? OwnerFirstName { get; set; }

    [StringLength(1000)]
    public string? OwnerForeignAddress { get; set; }

    [StringLength(1000)]
    public string? OwnerLastName { get; set; }

    [StringLength(1000)]
    public string? OwnerMotherFullName { get; set; }

    [StringLength(1000)]
    public string? OwnerOccupation { get; set; }

    [StringLength(1000)]
    public string? OwnerPassportIssuanceDate { get; set; }

    [StringLength(1000)]
    public string? OwnerPassportIssuancePlace { get; set; }

    [StringLength(1000)]
    public string? OwnerPassportNumber { get; set; }

    [StringLength(1000)]
    public string? OwnerPlaceOfBirth { get; set; }

    [StringLength(1000)]
    public string? OwnerZipCode { get; set; }

    [StringLength(1000)]
    public string? ProvisionalTpdNumber { get; set; }

    public string? TpdControlId { get; set; }

    [ForeignKey(nameof(TpdControlId))]
    public TpdControlDbModel? TpdControl { get; set; } = null;

    public string? TpdEntryAndExitHistoryId { get; set; }

    [ForeignKey(nameof(TpdEntryAndExitHistoryId))]
    public TpdEntryAndExitHistoryDbModel? TpdEntryAndExitHistory { get; set; } = null;

    public string? TpdVehicleId { get; set; }

    [ForeignKey(nameof(TpdVehicleId))]
    public TpdVehicleDbModel? TpdVehicle { get; set; } = null;

    public string? TravelerSearchHistoryId { get; set; }

    [ForeignKey(nameof(TravelerSearchHistoryId))]
    public TravelerSearchHistoryDbModel? TravelerSearchHistory { get; set; } = null;

    public string? TravelersArticlesEntryExitId { get; set; }

    [ForeignKey(nameof(TravelersArticlesEntryExitId))]
    public TravelersArticlesEntryExitDbModel? TravelersArticlesEntryExit { get; set; } = null;

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
