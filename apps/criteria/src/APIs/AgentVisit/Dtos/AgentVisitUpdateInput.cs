namespace Criteria.APIs.Dtos;

public class AgentVisitUpdateInput
{
    public string? AgencyCode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Id { get; set; }

    public string? ServiceCode { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? VerificationDate { get; set; }

    public string? VerifierId { get; set; }
}
