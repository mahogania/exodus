namespace Collection.APIs.Dtos;

public class BondReleaseWhereInput
{
    public double? AmountReturnedAfterRelease { get; set; }

    public DateTime? BondReleaseMoment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FinalReleaseYn { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public double? NumberOfBondReleases { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceNumberTypeCode { get; set; }

    public string? ReferenceNumberUsed { get; set; }

    public string? RequestNo { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
