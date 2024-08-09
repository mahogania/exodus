namespace Collection.APIs.Dtos;

public class ReimbursementCreateInput
{
    public string? AttachmentFileId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? OfficeCode { get; set; }

    public string? ReceiverSOpinion { get; set; }

    public string? RegistrationPersonIdentifier { get; set; }

    public double? ReimbursedAmount { get; set; }

    public string? ReimbursementDate { get; set; }

    public string? ReimbursementDecisionType { get; set; }

    public string? ReimbursementNo { get; set; }

    public string? ReimbursementReasonContent { get; set; }

    public string? ReimbursementRequestNo { get; set; }

    public DateTime UpdatedAt { get; set; }
}
