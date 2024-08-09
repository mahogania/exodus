namespace Collection.APIs.Dtos;

public class ReceptionWhereInput
{
    public string? AuthorizationCode { get; set; }

    public string? CardNo { get; set; }

    public string? CardValidityDuration { get; set; }

    public string? CardholderName { get; set; }

    public string? CollectionNo { get; set; }

    public string? ConnectionIp { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public string? ErrorMessageContent { get; set; }

    public string? ErrorsErrorCode { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? LinkingParameterContent { get; set; }

    public string? NoticeNo { get; set; }

    public string? OrderIdentifier { get; set; }

    public string? OrderNumber { get; set; }

    public string? OrderStatusParameter { get; set; }

    public DateTime? PaymentDateAndTime { get; set; }

    public string? ProcessingStatusCode { get; set; }

    public string? ProcessingStatusContent { get; set; }

    public string? ThreeDigitCountryCode { get; set; }

    public double? TotalNoticeAmount { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
