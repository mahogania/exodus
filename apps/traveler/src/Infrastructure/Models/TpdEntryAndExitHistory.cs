using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("TpdEntryAndExitHistories")]
public class TpdEntryAndExitHistoryDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? EntryAndExitSerialNumber { get; set; }

    [StringLength(1000)]
    public string? EntryExitCode { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<GeneralTravelerInformationTpdDbModel>? GeneralTravelerInformationTpds { get; set; } =
        new List<GeneralTravelerInformationTpdDbModel>();

    [Key()]
    [Required()]
    public string Id { get; set; }

    public List<ImportDeclarationDbModel>? ImportDeclarations { get; set; } =
        new List<ImportDeclarationDbModel>();

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? RegistrationDate { get; set; }

    public DateTime? RegistrationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? TpdManagementNumber { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
