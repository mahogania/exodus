using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("CancellationRequests")]
public class CancellationRequestDbModel
{
    [StringLength(1000)]
    public string? CancellationContent { get; set; }

    [StringLength(1000)]
    public string? CancellationReasonCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DateOfRequestForCancellation { get; set; }

    [StringLength(1000)]
    public string? FinalOn { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IdOfTheAttachedFile { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfCancellations { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    public string? RequestId { get; set; }

    [ForeignKey(nameof(RequestId))]
    public JournalDbModel? Request { get; set; } = null;

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
