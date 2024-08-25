namespace Control.APIs.Dtos;

public class ContainerValueAssessment
{
    public string? CommonVerification { get; set; }

    public string? ContainerNumber { get; set; }

    public string? ContainerSequenceNumber { get; set; }

    public string? ContainerStuffingStateCode { get; set; }

    public string? ContainerTypeCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? FinalModifierId { get; set; }

    public string Id { get; set; }

    public string? InitialRecorderId { get; set; }

    public string? SealNumber1 { get; set; }

    public string? SealNumber2_24310 { get; set; }

    public string? SealNumber3 { get; set; }

    public string? SealingPersonCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}
