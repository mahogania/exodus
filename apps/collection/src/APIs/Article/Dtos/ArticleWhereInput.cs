namespace Collection.APIs.Dtos;

public class ArticleWhereInput
{
    public double? ArticleSequenceNo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public string? DestructionMinutesNumber { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
