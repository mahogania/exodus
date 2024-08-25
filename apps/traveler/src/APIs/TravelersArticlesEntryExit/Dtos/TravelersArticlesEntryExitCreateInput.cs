namespace Traveler.APIs.Dtos;

public class TravelersArticlesEntryExitCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public double? DepositedArticleSerialNumber { get; set; }

    public string? EntryAndExitCategoryCode { get; set; }

    public double? ExitedWeight { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<GeneralTravelerInformationTpd>? GeneralTravelerInformationTpds { get; set; }

    public string? Id { get; set; }

    public List<ImportDeclaration>? ImportDeclarations { get; set; }

    public string? QuantityUnitCode { get; set; }

    public string? RemovalVoucherNumber { get; set; }

    public string? SectorCode { get; set; }

    public double? StockQuantity { get; set; }

    public double? StockWeight { get; set; }

    public string? TravelerName { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? WeightUnit { get; set; }
}
