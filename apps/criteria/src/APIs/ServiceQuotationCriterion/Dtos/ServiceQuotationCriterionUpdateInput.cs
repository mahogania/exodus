namespace Criteria.APIs.Dtos;

public class ServiceQuotationCriterionUpdateInput
{
    public string? AgencyCode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CriterionContent { get; set; }

    public DateTime? EndApplicationDate { get; set; }

    public string? Id { get; set; }

    public DateTime? StartApplicationDate { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
