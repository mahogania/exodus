namespace Control.APIs.Dtos;

public class ChangeInTheDetailedDeclarationWhereInput
{
    public string? CommonDetailedDeclaration { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public DateTime? DateAndTimeOfTreatmentDecision { get; set; }

    public bool? DeletionOn { get; set; }

    public string? ExecutionCodeByStatusTreatment { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public string? Id { get; set; }

    public string? StatusTreatmentCode { get; set; }

    public string? TreatmentStatusContent { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
