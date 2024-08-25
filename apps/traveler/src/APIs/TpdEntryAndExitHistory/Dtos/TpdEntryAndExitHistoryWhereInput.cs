namespace Traveler.APIs.Dtos;

public class TpdEntryAndExitHistoryWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public double? EntryAndExitSerialNumber { get; set; }

    public string? EntryExitCode { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<string>? GeneralTravelerInformationTpds { get; set; }

    public string? Id { get; set; }

    public List<string>? ImportDeclarations { get; set; }

    public string? OfficeCode { get; set; }

    public string? RegistrationDate { get; set; }

    public DateTime? RegistrationDateAndTime { get; set; }

    public string? TpdManagementNumber { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
