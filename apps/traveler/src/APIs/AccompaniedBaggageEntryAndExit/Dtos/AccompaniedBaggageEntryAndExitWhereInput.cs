namespace Traveler.APIs.Dtos;

public class AccompaniedBaggageEntryAndExitWhereInput
{
    public string? BaggageNumber { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public string? DepositBulletinNumber { get; set; }

    public string? EntryAndExitCategoryCode { get; set; }

    public string? ExitRequestDate { get; set; }

    public string? ExitRequestTypeCode { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<string>? GeneralTravelerInformationTpds { get; set; }

    public string? Id { get; set; }

    public string? OfficerId { get; set; }

    public string? PersonalEffectsClearanceNumber { get; set; }

    public string? RemovalDate { get; set; }

    public double? StockQuantity { get; set; }

    public double? StockWeight { get; set; }

    public string? TravelerName { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
