namespace Criteria.APIs.Dtos;

public class ServiceChangeCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? DetailedDeclarationNumber { get; set; }

    public string? Id { get; set; }

    public string? InitialServiceCode { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? ModificationNumber { get; set; }

    public string? ModificationResponsibleId { get; set; }

    public string? NewServiceCode { get; set; }

    public string? ReasonForModification { get; set; }

    public string? ServiceChangeReasonCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}
