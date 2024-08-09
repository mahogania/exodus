using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("OfficialReports")]
public class OfficialReportDbModel
{
    [StringLength(1000)]
    public string? AccountingMaterialManagementNumber { get; set; }

    [StringLength(1000)]
    public string? Address { get; set; }

    [StringLength(1000)]
    public string? AdjudicatorIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? AdjudicatorIdentificationNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? AdjudicatorSName { get; set; }

    [StringLength(1000)]
    public string? AlienationDate { get; set; }

    [StringLength(1000)]
    public string? AttachedFileId { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DecisionOfAssignmentNumber { get; set; }

    [StringLength(1000)]
    public string? DeletionFlag { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? ItemSequenceNumber { get; set; }

    [StringLength(1000)]
    public string? MinutesOfDefaultNumber { get; set; }

    [StringLength(1000)]
    public string? MinutesOfDefaultTypeCode { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? ReasonsForDefault { get; set; }

    [StringLength(1000)]
    public string? ReceiverId { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeName { get; set; }

    [StringLength(1000)]
    public string? RegistrationDate { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
