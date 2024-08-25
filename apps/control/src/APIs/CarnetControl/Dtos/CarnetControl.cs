using Control.Core.Enums;

namespace Control.APIs.Dtos;

public class CarnetControl
{
    public string? AtaCarnetManagementNumber { get; set; }

    public string? AttachedFileId { get; set; }

    public DateTime? AuthorizationDate { get; set; }

    public string? CarnetTypeCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? FinalModifierId { get; set; }

    public DateTime? GrantedDeadlineEndDate { get; set; }

    public string Id { get; set; }

    public string? InitialRecorderId { get; set; }

    public ProcessingStatusCodeEnum? ProcessingStatusCode { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? VerificationResultContent { get; set; }
}
