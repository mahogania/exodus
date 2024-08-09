using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("RemovalOrders")]
public class RemovalOrderDbModel
{
    [Range(-999999999, 999999999)]
    public double? ArticlePackageQuantity { get; set; }

    [StringLength(1000)]
    public string? ArticlePackageUnitCode { get; set; }

    [StringLength(1000)]
    public string? AttachedFileId { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Crn { get; set; }

    [StringLength(1000)]
    public string? CustomsZoneCode { get; set; }

    [StringLength(1000)]
    public string? DeclarantCode { get; set; }

    [StringLength(1000)]
    public string? DeclarantName { get; set; }

    [StringLength(1000)]
    public string? DeletionFlag { get; set; }

    [StringLength(1000)]
    public string? ExporterIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? ExporterIdentificationNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ExporterName { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? Forwarder { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ImporterIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? ImporterIdentificationNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ImporterName { get; set; }

    [StringLength(1000)]
    public string? NoticeNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfTimesRemovalOrderPrinted { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? PaymentDate { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)]
    public string? ReceiptNumber { get; set; }

    [StringLength(1000)]
    public string? ReferenceDate { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? RegistrationDate { get; set; }

    [StringLength(1000)]
    public string? RemarksContent { get; set; }

    [StringLength(1000)]
    public string? RemovalOrderNumber { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
