using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Managements")]
public class ManagementDbModel
{
    [StringLength(1000)]
    public string? AccountCode { get; set; }

    [StringLength(1000)]
    public string? AccountingServiceCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? ErrorDate { get; set; }

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
    public string? OperationReason { get; set; }

    [StringLength(1000)]
    public string? OrderOperationNumber { get; set; }

    [StringLength(1000)]
    public string? ReferenceFileRegistrationDate { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? WriterServiceCode { get; set; }
}
