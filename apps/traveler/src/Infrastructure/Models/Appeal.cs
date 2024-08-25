using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("Appeals")]
public class AppealDbModel
{
    [StringLength(1000)]
    public string? AppealRequestContents { get; set; }

    [StringLength(1000)]
    public string? AppealRequestResponseContents { get; set; }

    [StringLength(1000)]
    public string? CompetentCustomsOfficeCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? GeneralBondNoteId { get; set; }

    [ForeignKey(nameof(GeneralBondNoteId))]
    public GeneralBondNoteDbModel? GeneralBondNote { get; set; } = null;

    public List<GeneralTravelerInformationTpdDbModel>? GeneralTravelerInformationTpds { get; set; } =
        new List<GeneralTravelerInformationTpdDbModel>();

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfAppeals { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? Reject { get; set; }

    [StringLength(1000)]
    public string? Remark { get; set; }

    public DateTime? RequestDateAndTime { get; set; }

    public DateTime? ResponseDateTime { get; set; }

    [StringLength(1000)]
    public string? ResponsiblePersonId { get; set; }

    [StringLength(1000)]
    public string? ResponsibleServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
