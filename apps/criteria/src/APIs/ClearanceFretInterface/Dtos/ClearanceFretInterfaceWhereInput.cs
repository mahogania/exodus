namespace Criteria.APIs.Dtos;

public class ClearanceFretInterfaceWhereInput
{
    public double? AuthorizedGrossWeight { get; set; }

    public string? AuthorizedNetWeightUnitCodeProcessingOn { get; set; }

    public string? AuthorizedPackageUnitCode { get; set; }

    public int? AuthorizedPackagingNumber { get; set; }

    public List<string>? ClearanceFretContainer { get; set; }

    public string? ContainerizedCargoStorageLocationCode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Crn { get; set; }

    public string? DeclarantCode { get; set; }

    public string? DeclarationTypeCode { get; set; }

    public string? DetailedDeclarationNumber { get; set; }

    public string? EpcCode { get; set; }

    public string? Id { get; set; }

    public string? ProcessingContent { get; set; }

    public string? ProcessingResultCode { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? ValidationDate { get; set; }
}
