namespace Criteria.APIs.Dtos;

public class InspectorChangeWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public string? DetailedDeclarationNumber { get; set; }

    public string? Id { get; set; }

    public string? InitialVerifierId { get; set; }

    public string? InitialVisitOfficerId { get; set; }

    public string? InspectorChangeReasonCode { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? ModificationNumber { get; set; }

    public string? ModificationResponsibleId { get; set; }

    public string? NewInspectorId { get; set; }

    public string? NewVisitOfficerId { get; set; }

    public string? ReasonForModification { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
