using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Statement.Infrastructure.Models;

[Table("Cancellations")]
public class CancellationDbModel
{
    [Required()]
    public string AttachedFile { get; set; }

    [StringLength(1000)]
    public string? CnclCn { get; set; }

    [Range(0, 999999999)]
    public int? CnclDgcnt { get; set; }

    public DateTime? CnclRqstDt { get; set; }

    [StringLength(1000)]
    public string? CnclRsnCd { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public bool? DelOn { get; set; }

    [StringLength(1000)]
    public string? FrstRegstId { get; set; }

    public DateTime? FrstRgsrDttm { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public DateTime? LastChgDttm { get; set; }

    [StringLength(1000)]
    public string? LastChprId { get; set; }

    public bool? LastOn { get; set; }

    [StringLength(1000)]
    public string? PrcsSttsCd { get; set; }

    [StringLength(70)]
    public string? ReffNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
