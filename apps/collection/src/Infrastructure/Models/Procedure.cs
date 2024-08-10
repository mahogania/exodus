using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Procedures")]
public class ProcedureDbModel
{
    [StringLength(1000)] public string? AttachedFileId { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? DeletionFlag { get; set; }

    [StringLength(1000)] public string? EtcYOrN { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    [StringLength(1000)] public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [StringLength(1000)] public string? HandoverDate { get; set; }

    [StringLength(1000)] public string? HandoverNoteNumber { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? IncomingReceiverId { get; set; }

    [StringLength(1000)] public string? OfficeCode { get; set; }

    [StringLength(1000)] public string? OtherContents { get; set; }

    [StringLength(1000)] public string? OutgoingReceiverId { get; set; }

    [StringLength(1000)] public string? PhysicalInventoryOfEquipmentAndFurnitureYOrN { get; set; }

    [StringLength(1000)] public string? ServiceCode { get; set; }

    [StringLength(1000)] public string? StateOfCashYOrN { get; set; }

    [StringLength(1000)] public string? StateOfExpenseCertificatesStoppedYOrN { get; set; }

    [StringLength(1000)] public string? StateOfReceiptsStoppedYOrN { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}
