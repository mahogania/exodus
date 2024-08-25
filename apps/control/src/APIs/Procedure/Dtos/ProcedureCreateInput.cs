namespace Control.APIs.Dtos;

public class ProcedureCreateInput
{
    public List<AnalysisRequest>? AnalysisRequests { get; set; }

    public List<CancellationRequest>? CancellationRequests { get; set; }

    public List<CommonActiveGoodsRequest>? CommonActiveGoodsRequests { get; set; }

    public CommonDetailedDeclaration? CommonDetailedDeclaration { get; set; }

    public List<CommonExpressClearance>? CommonExpressClearances { get; set; }

    public List<CommonOriginCertificateRequest>? CommonOriginCertificateRequests { get; set; }

    public List<CommonRegimeRequest>? CommonRegimeRequests { get; set; }

    public DateTime CreatedAt { get; set; }

    public List<ForeignOperatorRequest>? ForeignOperatorRequests { get; set; }

    public string? Id { get; set; }

    public List<PostalGoodsClearance>? PostalGoodsClearances { get; set; }

    public List<PostalParcelSimplifiedClearance>? PostalParcelSimplifiedClearances { get; set; }

    public List<RecourseRequest>? RecourseRequests { get; set; }

    public DateTime UpdatedAt { get; set; }
}
