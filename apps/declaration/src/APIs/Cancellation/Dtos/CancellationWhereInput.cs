namespace Statement.APIs.Dtos;

public class CancellationWhereInput
{
    public string? AttachedFile { get; set; }

    public string? CnclCn { get; set; }

    public int? CnclDgcnt { get; set; }

    public DateTime? CnclRqstDt { get; set; }

    public string? CnclRsnCd { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? DelOn { get; set; }

    public string? FrstRegstId { get; set; }

    public DateTime? FrstRgsrDttm { get; set; }

    public string? Id { get; set; }

    public DateTime? LastChgDttm { get; set; }

    public string? LastChprId { get; set; }

    public bool? LastOn { get; set; }

    public string? PrcsSttsCd { get; set; }

    public string? ReffNo { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
