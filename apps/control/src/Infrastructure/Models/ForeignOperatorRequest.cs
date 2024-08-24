using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ForeignOperatorRequests")]
public class ForeignOperatorRequestDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRecorderSId { get; set; }

    [StringLength(1000)]
    public string? ForeignOperatorAddress { get; set; }

    [StringLength(1000)]
    public string? ForeignOperatorCityCode { get; set; }

    [StringLength(1000)]
    public string? ForeignOperatorCode { get; set; }

    [StringLength(1000)]
    public string? ForeignOperatorCompanyName { get; set; }

    [StringLength(1000)]
    public string? ForeignOperatorCountryCode { get; set; }

    [StringLength(1000)]
    public string? ForeignOperatorEmail { get; set; }

    [StringLength(1000)]
    public string? ForeignOperatorPhoneNumber { get; set; }

    [StringLength(1000)]
    public string? ForeignOperatorRepresentativeName { get; set; }

    [StringLength(1000)]
    public string? ForeignOperatorRequestNumber { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ProcessingDate { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    public string? RequestId { get; set; }

    [ForeignKey(nameof(RequestId))]
    public JournalDbModel? Request { get; set; } = null;

    [StringLength(1000)]
    public string? RequestDate { get; set; }

    [StringLength(1000)]
    public string? RequestReasonContent { get; set; }

    [StringLength(1000)]
    public string? RequestTypeCode { get; set; }

    [StringLength(1000)]
    public string? RequestingPersonId { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? VerificationOpinionContent { get; set; }
}
