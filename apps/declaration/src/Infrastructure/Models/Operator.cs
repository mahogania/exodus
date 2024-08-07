using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Statement.Infrastructure.Models;

[Table("Operators")]
public class OperatorDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DcerAddr { get; set; }

    [StringLength(1000)]
    public string? DcerCoNm { get; set; }

    [StringLength(1000)]
    public string? DelOn { get; set; }

    [StringLength(256)]
    public string? ExppnAddr { get; set; }

    [StringLength(1000)]
    public string? ExppnCoNm { get; set; }

    public string? ExppnEml { get; set; }

    [StringLength(1000)]
    public string? FrstRegstId { get; set; }

    public DateTime? FrstRgsrDttm { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ImppnAddr { get; set; }

    [StringLength(1000)]
    public string? ImppnCoNm { get; set; }

    public DateTime? LastChgDttm { get; set; }

    [StringLength(1000)]
    public string? LastChprId { get; set; }

    [StringLength(1000)]
    public string? MdfyDgcnt { get; set; }

    [StringLength(1000)]
    public string? ReffNo { get; set; }

    [StringLength(1000)]
    public string? TxprAddr { get; set; }

    [StringLength(1000)]
    public string? TxprCoNm { get; set; }

    public string? TxprEml { get; set; }

    [StringLength(1000)]
    public string? TxprTlphNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
