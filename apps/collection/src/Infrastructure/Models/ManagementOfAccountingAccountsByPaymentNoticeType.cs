using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("ManagementOfAccountingAccountsByPaymentNoticeTypes")]
public class ManagementOfAccountingAccountsByPaymentNoticeTypeDbModel
{
    [StringLength(1000)]
    public string? AccountCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? AlignmentOrder { get; set; }

    [StringLength(1000)]
    public string? ApplicationStartDate { get; set; }

    [StringLength(1000)]
    public string? AuxiliaryJournalDesignation { get; set; }

    [StringLength(1000)]
    public string? BalanceSheetCategoryCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? DetailSequenceNo { get; set; }

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
    public string? NoticeTypeCode { get; set; }

    [StringLength(1000)]
    public string? PartialOrParticularDistribution { get; set; }

    [StringLength(1000)]
    public string? ReasonCodeByPaymentNoticeType { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
