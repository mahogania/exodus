using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fret.Infrastructure.Models;

[Table("Manifests")]
public class ManifestDbModel
{
    [Range(-999999999, 999999999)]
    public int? AlBlGcnt { get; set; }

    [Range(-999999999, 999999999)]
    public int? AlCntrGcnt { get; set; }

    [Range(-999999999, 999999999)]
    public int? AlEcntrCnt { get; set; }

    [Range(-999999999, 999999999)]
    public double? AlNtwg { get; set; }

    [Range(-999999999, 999999999)]
    public int? AlPckgGcnt { get; set; }

    [Range(-999999999, 999999999)]
    public double? AlTtwg { get; set; }

    [Range(-999999999, 999999999)]
    public int? AlVhclGcnt { get; set; }

    [StringLength(1000)]
    public string? ApreOnCd { get; set; }

    public DateTime? ArvlDttm { get; set; }

    [StringLength(1000)]
    public string? AtchFileId { get; set; }

    [StringLength(1000)]
    public string? AudtOpinCn { get; set; }

    [StringLength(1000)]
    public string? CagDcshRgsrMgmtNo { get; set; }

    [StringLength(1000)]
    public string? CagRqstTpCd { get; set; }

    [StringLength(1000)]
    public string? CarrAddrNm { get; set; }

    [StringLength(1000)]
    public string? CarrCd { get; set; }

    [StringLength(1000)]
    public string? CoRqstNo { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public bool? DelOn { get; set; }

    public DateTime? DptrDttm { get; set; }

    [StringLength(1000)]
    public string? DptrPortCd { get; set; }

    [StringLength(1000)]
    public string? DrvrNm { get; set; }

    [Range(-999999999, 999999999)]
    public double? EurFxrt { get; set; }

    [StringLength(1000)]
    public string? FrstRegstId { get; set; }

    public DateTime? FrstRgsrDttm { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ImoNo { get; set; }

    [StringLength(1000)]
    public string? JrsdOrgnCd { get; set; }

    public DateTime? LastChgDttm { get; set; }

    [StringLength(1000)]
    public string? LastChprId { get; set; }

    public DateTime? LastLdunDt { get; set; }

    [StringLength(1000)]
    public string? LastThrgPortCd { get; set; }

    [Range(-999999999, 999999999)]
    public int? LdunBlGcnt { get; set; }

    [StringLength(1000)]
    public string? LoadRqstNo { get; set; }

    public bool? LtspOn { get; set; }

    [StringLength(1000)]
    public string? Mrn { get; set; }

    public DateTime? PrcsDttm { get; set; }

    [StringLength(1000)]
    public string? PrcsSttsCd { get; set; }

    public DateTime? RealArvlDttm { get; set; }

    [StringLength(1000)]
    public string? ShipNttn { get; set; }

    [StringLength(1000)]
    public string? ShipTtn { get; set; }

    [StringLength(1000)]
    public string? TrnpMeanCd { get; set; }

    [StringLength(1000)]
    public string? TrnpMethIdfyNo { get; set; }

    public string? TrnpMethLoctNm { get; set; }

    [StringLength(1000)]
    public string? TrnpMethNatCd { get; set; }

    [StringLength(1000)]
    public string? TrnpMethNm { get; set; }

    public DateTime? TrnpMethRgsrDt { get; set; }

    [StringLength(1000)]
    public string? TrnpRferNo { get; set; }

    [StringLength(1000)]
    public string? TrsnCoCd { get; set; }

    public DateTime? TrsnDttm { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? UsdFxrt { get; set; }
}
