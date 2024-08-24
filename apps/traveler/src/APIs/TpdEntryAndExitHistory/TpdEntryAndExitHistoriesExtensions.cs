using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class TpdEntryAndExitHistoriesExtensions
{
    public static TpdEntryAndExitHistory ToDto(this TpdEntryAndExitHistoryDbModel model)
    {
        return new TpdEntryAndExitHistory
        {
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            EntryAndExitSerialNumber = model.EntryAndExitSerialNumber,
            EntryExitCode = model.EntryExitCode,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            Id = model.Id,
            ImportDeclarations = model.ImportDeclarations?.Select(x => x.Id).ToList(),
            OfficeCode = model.OfficeCode,
            RegistrationDate = model.RegistrationDate,
            RegistrationDateAndTime = model.RegistrationDateAndTime,
            TpdManagementNumber = model.TpdManagementNumber,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static TpdEntryAndExitHistoryDbModel ToModel(
        this TpdEntryAndExitHistoryUpdateInput updateDto,
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId
    )
    {
        var tpdEntryAndExitHistory = new TpdEntryAndExitHistoryDbModel
        {
            Id = uniqueId.Id,
            DeletionOn = updateDto.DeletionOn,
            EntryAndExitSerialNumber = updateDto.EntryAndExitSerialNumber,
            EntryExitCode = updateDto.EntryExitCode,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            OfficeCode = updateDto.OfficeCode,
            RegistrationDate = updateDto.RegistrationDate,
            RegistrationDateAndTime = updateDto.RegistrationDateAndTime,
            TpdManagementNumber = updateDto.TpdManagementNumber
        };

        if (updateDto.CreatedAt != null)
        {
            tpdEntryAndExitHistory.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            tpdEntryAndExitHistory.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return tpdEntryAndExitHistory;
    }
}
