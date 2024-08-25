namespace Criteria.APIs.Dtos;

public class InspectorQuotationStat
{
    public int? AffectationNumber { get; set; }

    public string AgencyCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Id { get; set; }

    public string InspectorId { get; set; }

    public DateTime QuotationDate { get; set; }

    public string ServiceCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}
