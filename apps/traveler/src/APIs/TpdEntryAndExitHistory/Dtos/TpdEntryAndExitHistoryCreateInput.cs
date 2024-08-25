namespace Traveler.APIs.Dtos;

public class TpdEntryAndExitHistoryCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public double? EntryAndExitSerialNumber { get; set; }

    public string? EntryExitCode { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<GeneralTravelerInformationTpd>? GeneralTravelerInformationTpds { get; set; }

    public string? Id { get; set; }

    public List<ImportDeclaration>? ImportDeclarations { get; set; }

    public string? OfficeCode { get; set; }

    public string? RegistrationDate { get; set; }

    public DateTime? RegistrationDateAndTime { get; set; }

    public string? TpdManagementNumber { get; set; }

    public DateTime UpdatedAt { get; set; }
}
