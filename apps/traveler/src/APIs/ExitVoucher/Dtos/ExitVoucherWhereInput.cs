namespace Traveler.APIs.Dtos;

public class ExitVoucherWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public string? ExitRequestDate { get; set; }

    public double? ExitVoucherSerialNumber { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<string>? GeneralTravelerInformationTpds { get; set; }

    public string? Id { get; set; }

    public string? OfficeCode { get; set; }

    public string? ReferenceNumber { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? VerifierId { get; set; }
}
