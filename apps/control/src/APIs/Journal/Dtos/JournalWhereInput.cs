namespace Control.APIs.Dtos;

public class JournalWhereInput
{
    public List<string>? CancellationRequests { get; set; }

    public List<string>? CommonActiveGoodsRequests { get; set; }

    public string? CommonDetailedDeclaration { get; set; }

    public List<string>? CommonOriginCertificateRequests { get; set; }

    public List<string>? CommonRegimeRequests { get; set; }

    public DateTime? CreatedAt { get; set; }

    public List<string>? ForeignOperatorRequests { get; set; }

    public string? Id { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
