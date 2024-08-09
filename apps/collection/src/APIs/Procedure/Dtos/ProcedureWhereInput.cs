namespace Collection.APIs.Dtos;

public class ProcedureWhereInput
{
    public string? AttachedFileId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionFlag { get; set; }

    public string? EtcYOrN { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? HandoverDate { get; set; }

    public string? HandoverNoteNumber { get; set; }

    public string? Id { get; set; }

    public string? IncomingReceiverId { get; set; }

    public string? OfficeCode { get; set; }

    public string? OtherContents { get; set; }

    public string? OutgoingReceiverId { get; set; }

    public string? PhysicalInventoryOfEquipmentAndFurnitureYOrN { get; set; }

    public string? ServiceCode { get; set; }

    public string? StateOfCashYOrN { get; set; }

    public string? StateOfExpenseCertificatesStoppedYOrN { get; set; }

    public string? StateOfReceiptsStoppedYOrN { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
