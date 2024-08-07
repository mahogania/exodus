namespace Statement.APIs.Dtos;

public class AttachmentCreateInput
{
    public int? AtchDocSrno { get; set; }

    public string? AtchFileId { get; set; }

    public string? AtchFileNm { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool? DelOn { get; set; }

    public string? DocDesc { get; set; }

    public string? DocKndCd { get; set; }

    public string? DocNo { get; set; }

    public string? FrstRegstId { get; set; }

    public DateTime? FrstRgsrDttm { get; set; }

    public string? Id { get; set; }

    public DateTime? LastChgDttm { get; set; }

    public string? LastChprId { get; set; }

    public int? MdfyDgcnt { get; set; }

    public string? PblsDt { get; set; }

    public string? PblsIttNm { get; set; }

    public string? PdlsNo { get; set; }

    public string? ReffNo { get; set; }

    public DateTime UpdatedAt { get; set; }
}
