namespace Control.APIs.Dtos;

public class SampleRequestWhereInput
{
    public string? AnalysisExpertiseRequestId { get; set; }

    public string? AnalysisRequest { get; set; }

    public string? Article { get; set; }

    public string? ArticleName { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeclarantCode { get; set; }

    public bool? DeclarantPresence { get; set; }

    public string? DetailedDeclarationId { get; set; }

    public string? Id { get; set; }

    public int? Quantity { get; set; }

    public string? RequestTypeId { get; set; }

    public int? RestitutedSampleQuantity { get; set; }

    public int? RestitutedSampleWeight { get; set; }

    public DateTime? SampleCollectionDate { get; set; }

    public DateTime? SampleCollectionEndDate { get; set; }

    public DateTime? SampleCollectionStartDate { get; set; }

    public string? SampleDescription { get; set; }

    public DateTime? SampleRequestDate { get; set; }

    public bool? SampleRestitution { get; set; }

    public bool? SampleRestitutionConfirmation { get; set; }

    public DateTime? SampleRestitutionDate { get; set; }

    public string? SuspicionResultsContents { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? Weight { get; set; }
}
