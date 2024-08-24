namespace Traveler.APIs.Dtos;

public class AppealWhereInput
{
    public string? AppealRequestContents { get; set; }

    public string? AppealRequestResponseContents { get; set; }

    public string? CompetentCustomsOfficeCode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? GeneralBondNote { get; set; }

    public List<string>? GeneralTravelerInformationTpds { get; set; }

    public string? Id { get; set; }

    public double? NumberOfAppeals { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? Reject { get; set; }

    public string? Remark { get; set; }

    public DateTime? RequestDateAndTime { get; set; }

    public DateTime? ResponseDateTime { get; set; }

    public string? ResponsiblePersonId { get; set; }

    public string? ResponsibleServiceCode { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
