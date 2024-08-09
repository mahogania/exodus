using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("VariousRequests")]
public class VariousRequestDbModel
{
    [StringLength(1000)]
    public string? AttachmentFileId { get; set; }

    [StringLength(1000)]
    public string? CodeJustificationDescription { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeclarantCode { get; set; }

    [StringLength(1000)]
    public string? DeclarantName { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? ProcessingDate { get; set; }

    [StringLength(1000)]
    public string? ProcessingResult { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)]
    public string? ReceiverId { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? RequestDate { get; set; }

    [StringLength(1000)]
    public string? RequestNo { get; set; }

    [StringLength(1000)]
    public string? RequestTypeCode { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
