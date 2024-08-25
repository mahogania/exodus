namespace Control.APIs.Dtos;

public class AppealUpdateInput
{
    public string? AppealContent { get; set; }

    public string? AttachedFileId { get; set; }

    public List<string>? CommonVerifications { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public bool? DeletedOn { get; set; }

    public string? FinalModifierId { get; set; }

    public string? Id { get; set; }

    public string? InitialRecorderId { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
