namespace Traveler.APIs.Dtos;

public class GeneralTravelerInformationTpdCreateInput
{
    public AccompaniedBaggageEntryAndExit? AccompaniedBaggageEntryAndExit { get; set; }

    public Appeal? Appeal { get; set; }

    public BaggageControlArticle? BaggageControlArticle { get; set; }

    public string? CommanderNationalityCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public string? DriverAddress { get; set; }

    public string? DriverDateOfBirth { get; set; }

    public string? DriverFatherFullName { get; set; }

    public string? DriverFirstName { get; set; }

    public string? DriverForeignAddress { get; set; }

    public string? DriverLastName { get; set; }

    public string? DriverMotherFullName { get; set; }

    public string? DriverOccupation { get; set; }

    public string? DriverPassportIssuanceDate { get; set; }

    public string? DriverPassportIssuancePlace { get; set; }

    public string? DriverPassportNumber { get; set; }

    public string? DriverPlaceOfBirth { get; set; }

    public string? DriverTypeCode { get; set; }

    public string? DriverZipCode { get; set; }

    public ExitVoucher? ExitVoucher { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public GeneralBondNote? GeneralBondNote { get; set; }

    public string? Id { get; set; }

    public ImportDeclaration? ImportDeclaration { get; set; }

    public InspectorRatingModificationHistory? InspectorRatingModificationHistory { get; set; }

    public string? OwnerAddress { get; set; }

    public string? OwnerCountryCode { get; set; }

    public string? OwnerDateOfBirth { get; set; }

    public string? OwnerFatherFullName { get; set; }

    public string? OwnerFirstName { get; set; }

    public string? OwnerForeignAddress { get; set; }

    public string? OwnerLastName { get; set; }

    public string? OwnerMotherFullName { get; set; }

    public string? OwnerOccupation { get; set; }

    public string? OwnerPassportIssuanceDate { get; set; }

    public string? OwnerPassportIssuancePlace { get; set; }

    public string? OwnerPassportNumber { get; set; }

    public string? OwnerPlaceOfBirth { get; set; }

    public string? OwnerZipCode { get; set; }

    public string? ProvisionalTpdNumber { get; set; }

    public TpdControl? TpdControl { get; set; }

    public TpdEntryAndExitHistory? TpdEntryAndExitHistory { get; set; }

    public TpdVehicle? TpdVehicle { get; set; }

    public TravelerSearchHistory? TravelerSearchHistory { get; set; }

    public TravelersArticlesEntryExit? TravelersArticlesEntryExit { get; set; }

    public DateTime UpdatedAt { get; set; }
}
