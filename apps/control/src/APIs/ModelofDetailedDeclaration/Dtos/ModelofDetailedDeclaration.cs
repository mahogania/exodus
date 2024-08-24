namespace Control.APIs.Dtos;

public class ModelofDetailedDeclaration
{
    public string? Article { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public DateTime? DeletionOn { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrarId { get; set; }

    public string Id { get; set; }

    public double? InvoiceAmount { get; set; }

    public string? ModelAndSpecificationNameComponent { get; set; }

    public int? Quantity { get; set; }

    public string? UnitOfQuantityCode { get; set; }

    public double? UnitPrice { get; set; }

    public DateTime UpdatedAt { get; set; }
}
