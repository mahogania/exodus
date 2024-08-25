namespace Control.APIs.Dtos;

public class Procedure
{
    public List<string>? AnalysisRequests { get; set; }

    public List<string>? CancellationRequests { get; set; }

    public List<string>? CommonActiveGoodsRequests { get; set; }

    public string? CommonDetailedDeclaration { get; set; }

    public List<string>? CommonExpressClearances { get; set; }

    public List<string>? CommonOriginCertificateRequests { get; set; }

    public List<string>? CommonRegimeRequests { get; set; }

    public DateTime CreatedAt { get; set; }

    public List<string>? ForeignOperatorRequests { get; set; }

    public string Id { get; set; }

    public List<string>? PostalGoodsClearances { get; set; }

    public List<string>? PostalParcelSimplifiedClearances { get; set; }

    public List<string>? RecourseRequests { get; set; }

    public DateTime UpdatedAt { get; set; }
}
