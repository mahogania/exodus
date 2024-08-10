using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("CommonExpressClearances")]
public class CommonExpressClearanceDbModel
{
    [StringLength(1000)] public string? ArrivalDate { get; set; }

    [StringLength(1000)] public string? AttachedFileId { get; set; }

    [StringLength(1000)] public string? CountryOfLoadingCode { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? CustomsOfficeCode { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    [StringLength(1000)] public string? ExpressClearanceRequestNumber { get; set; }

    [StringLength(1000)] public string? ExpressOperatorCode { get; set; }

    [StringLength(1000)] public string? ExpressOperatorName { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierSId { get; set; }

    [StringLength(1000)] public string? FirstRecorderSId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? MasterBlNumber { get; set; }

    [StringLength(1000)] public string? RequestDate { get; set; }

    [StringLength(1000)] public string? ShipName { get; set; }

    [StringLength(1000)] public string? TransmissionTypeCode { get; set; }

    [StringLength(1000)] public string? TreatmentStatusCode { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}
