using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Statement.Infrastructure.Models;

[Table("Containers")]
public class ContainerDbModel
{
    [StringLength(1000)]
    public string? CntrNo { get; set; }

    [StringLength(1000)]
    public string? CntrSrno { get; set; }

    [StringLength(1000)]
    public string? CntrStfnSttsCd { get; set; }

    [StringLength(1000)]
    public string? CntrTpCd { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DelOn { get; set; }

    [StringLength(1000)]
    public string? FrstRegstId { get; set; }

    public DateTime? FrstRgsrDttm { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public DateTime? LastChgDttm { get; set; }

    [StringLength(1000)]
    public string? LastChprId { get; set; }

    [StringLength(1000)]
    public string? MdfyDgcnt { get; set; }

    [StringLength(256)]
    public string? RefNo { get; set; }

    [StringLength(1000)]
    public string? SealChpn1 { get; set; }

    [StringLength(1000)]
    public string? SealChpn2 { get; set; }

    [StringLength(1000)]
    public string? SealChpn3 { get; set; }

    [StringLength(1000)]
    public string? SealChpnCd { get; set; }

    [StringLength(1000)]
    public string? SealNo1 { get; set; }

    [StringLength(1000)]
    public string? SealNo2 { get; set; }

    [StringLength(1000)]
    public string? SealNo3 { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
