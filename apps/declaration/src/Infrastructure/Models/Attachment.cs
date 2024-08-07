using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Statement.Infrastructure.Models;

[Table("Attachments")]
public class AttachmentDbModel
{
    [Range(-999999999, 999999999)]
    public int? AtchDocSrno { get; set; }

    [StringLength(1000)]
    public string? AtchFileId { get; set; }

    [StringLength(1000)]
    public string? AtchFileNm { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public bool? DelOn { get; set; }

    [StringLength(1000)]
    public string? DocDesc { get; set; }

    [StringLength(1000)]
    public string? DocKndCd { get; set; }

    [StringLength(1000)]
    public string? DocNo { get; set; }

    [StringLength(1000)]
    public string? FrstRegstId { get; set; }

    public DateTime? FrstRgsrDttm { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public DateTime? LastChgDttm { get; set; }

    [StringLength(1000)]
    public string? LastChprId { get; set; }

    [Range(-999999999, 999999999)]
    public int? MdfyDgcnt { get; set; }

    [StringLength(1000)]
    public string? PblsDt { get; set; }

    [StringLength(1000)]
    public string? PblsIttNm { get; set; }

    [StringLength(1000)]
    public string? PdlsNo { get; set; }

    [StringLength(1000)]
    public string? ReffNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
