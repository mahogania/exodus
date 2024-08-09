namespace Collection.APIs.Dtos;

public class OfficialReportCreateInput
{
    public string? AccountingMaterialManagementNumber { get; set; }

    public string? Address { get; set; }

    public string? AdjudicatorIdentificationNumber { get; set; }

    public string? AdjudicatorIdentificationNumberTypeCode { get; set; }

    public string? AdjudicatorSName { get; set; }

    public string? AlienationDate { get; set; }

    public string? AttachedFileId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DecisionOfAssignmentNumber { get; set; }

    public string? DeletionFlag { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public double? ItemSequenceNumber { get; set; }

    public string? MinutesOfDefaultNumber { get; set; }

    public string? MinutesOfDefaultTypeCode { get; set; }

    public string? OfficeCode { get; set; }

    public string? ReasonsForDefault { get; set; }

    public string? ReceiverId { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? ReferenceNumberTypeCode { get; set; }

    public string? ReferenceNumberTypeName { get; set; }

    public string? RegistrationDate { get; set; }

    public string? ServiceCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}
