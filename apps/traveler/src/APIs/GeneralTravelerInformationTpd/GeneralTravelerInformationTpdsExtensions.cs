using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class GeneralTravelerInformationTpdsExtensions
{
    public static GeneralTravelerInformationTpd ToDto(
        this GeneralTravelerInformationTpdDbModel model
    )
    {
        return new GeneralTravelerInformationTpd
        {
            AccompaniedBaggageEntryAndExit = model.AccompaniedBaggageEntryAndExitId,
            Appeal = model.AppealId,
            BaggageControlArticle = model.BaggageControlArticleId,
            CommanderNationalityCode = model.CommanderNationalityCode,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            DriverAddress = model.DriverAddress,
            DriverDateOfBirth = model.DriverDateOfBirth,
            DriverFatherFullName = model.DriverFatherFullName,
            DriverFirstName = model.DriverFirstName,
            DriverForeignAddress = model.DriverForeignAddress,
            DriverLastName = model.DriverLastName,
            DriverMotherFullName = model.DriverMotherFullName,
            DriverOccupation = model.DriverOccupation,
            DriverPassportIssuanceDate = model.DriverPassportIssuanceDate,
            DriverPassportIssuancePlace = model.DriverPassportIssuancePlace,
            DriverPassportNumber = model.DriverPassportNumber,
            DriverPlaceOfBirth = model.DriverPlaceOfBirth,
            DriverTypeCode = model.DriverTypeCode,
            DriverZipCode = model.DriverZipCode,
            ExitVoucher = model.ExitVoucherId,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GeneralBondNote = model.GeneralBondNoteId,
            Id = model.Id,
            ImportDeclaration = model.ImportDeclarationId,
            InspectorRatingModificationHistory = model.InspectorRatingModificationHistoryId,
            OwnerAddress = model.OwnerAddress,
            OwnerCountryCode = model.OwnerCountryCode,
            OwnerDateOfBirth = model.OwnerDateOfBirth,
            OwnerFatherFullName = model.OwnerFatherFullName,
            OwnerFirstName = model.OwnerFirstName,
            OwnerForeignAddress = model.OwnerForeignAddress,
            OwnerLastName = model.OwnerLastName,
            OwnerMotherFullName = model.OwnerMotherFullName,
            OwnerOccupation = model.OwnerOccupation,
            OwnerPassportIssuanceDate = model.OwnerPassportIssuanceDate,
            OwnerPassportIssuancePlace = model.OwnerPassportIssuancePlace,
            OwnerPassportNumber = model.OwnerPassportNumber,
            OwnerPlaceOfBirth = model.OwnerPlaceOfBirth,
            OwnerZipCode = model.OwnerZipCode,
            ProvisionalTpdNumber = model.ProvisionalTpdNumber,
            TpdControl = model.TpdControlId,
            TpdEntryAndExitHistory = model.TpdEntryAndExitHistoryId,
            TpdVehicle = model.TpdVehicleId,
            TravelerSearchHistory = model.TravelerSearchHistoryId,
            TravelersArticlesEntryExit = model.TravelersArticlesEntryExitId,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static GeneralTravelerInformationTpdDbModel ToModel(
        this GeneralTravelerInformationTpdUpdateInput updateDto,
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = new GeneralTravelerInformationTpdDbModel
        {
            Id = uniqueId.Id,
            CommanderNationalityCode = updateDto.CommanderNationalityCode,
            DeletionOn = updateDto.DeletionOn,
            DriverAddress = updateDto.DriverAddress,
            DriverDateOfBirth = updateDto.DriverDateOfBirth,
            DriverFatherFullName = updateDto.DriverFatherFullName,
            DriverFirstName = updateDto.DriverFirstName,
            DriverForeignAddress = updateDto.DriverForeignAddress,
            DriverLastName = updateDto.DriverLastName,
            DriverMotherFullName = updateDto.DriverMotherFullName,
            DriverOccupation = updateDto.DriverOccupation,
            DriverPassportIssuanceDate = updateDto.DriverPassportIssuanceDate,
            DriverPassportIssuancePlace = updateDto.DriverPassportIssuancePlace,
            DriverPassportNumber = updateDto.DriverPassportNumber,
            DriverPlaceOfBirth = updateDto.DriverPlaceOfBirth,
            DriverTypeCode = updateDto.DriverTypeCode,
            DriverZipCode = updateDto.DriverZipCode,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            OwnerAddress = updateDto.OwnerAddress,
            OwnerCountryCode = updateDto.OwnerCountryCode,
            OwnerDateOfBirth = updateDto.OwnerDateOfBirth,
            OwnerFatherFullName = updateDto.OwnerFatherFullName,
            OwnerFirstName = updateDto.OwnerFirstName,
            OwnerForeignAddress = updateDto.OwnerForeignAddress,
            OwnerLastName = updateDto.OwnerLastName,
            OwnerMotherFullName = updateDto.OwnerMotherFullName,
            OwnerOccupation = updateDto.OwnerOccupation,
            OwnerPassportIssuanceDate = updateDto.OwnerPassportIssuanceDate,
            OwnerPassportIssuancePlace = updateDto.OwnerPassportIssuancePlace,
            OwnerPassportNumber = updateDto.OwnerPassportNumber,
            OwnerPlaceOfBirth = updateDto.OwnerPlaceOfBirth,
            OwnerZipCode = updateDto.OwnerZipCode,
            ProvisionalTpdNumber = updateDto.ProvisionalTpdNumber
        };

        if (updateDto.AccompaniedBaggageEntryAndExit != null)
        {
            generalTravelerInformationTpd.AccompaniedBaggageEntryAndExitId =
                updateDto.AccompaniedBaggageEntryAndExit;
        }
        if (updateDto.Appeal != null)
        {
            generalTravelerInformationTpd.AppealId = updateDto.Appeal;
        }
        if (updateDto.BaggageControlArticle != null)
        {
            generalTravelerInformationTpd.BaggageControlArticleId = updateDto.BaggageControlArticle;
        }
        if (updateDto.CreatedAt != null)
        {
            generalTravelerInformationTpd.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.ExitVoucher != null)
        {
            generalTravelerInformationTpd.ExitVoucherId = updateDto.ExitVoucher;
        }
        if (updateDto.GeneralBondNote != null)
        {
            generalTravelerInformationTpd.GeneralBondNoteId = updateDto.GeneralBondNote;
        }
        if (updateDto.ImportDeclaration != null)
        {
            generalTravelerInformationTpd.ImportDeclarationId = updateDto.ImportDeclaration;
        }
        if (updateDto.InspectorRatingModificationHistory != null)
        {
            generalTravelerInformationTpd.InspectorRatingModificationHistoryId =
                updateDto.InspectorRatingModificationHistory;
        }
        if (updateDto.TpdControl != null)
        {
            generalTravelerInformationTpd.TpdControlId = updateDto.TpdControl;
        }
        if (updateDto.TpdEntryAndExitHistory != null)
        {
            generalTravelerInformationTpd.TpdEntryAndExitHistoryId =
                updateDto.TpdEntryAndExitHistory;
        }
        if (updateDto.TpdVehicle != null)
        {
            generalTravelerInformationTpd.TpdVehicleId = updateDto.TpdVehicle;
        }
        if (updateDto.TravelerSearchHistory != null)
        {
            generalTravelerInformationTpd.TravelerSearchHistoryId = updateDto.TravelerSearchHistory;
        }
        if (updateDto.TravelersArticlesEntryExit != null)
        {
            generalTravelerInformationTpd.TravelersArticlesEntryExitId =
                updateDto.TravelersArticlesEntryExit;
        }
        if (updateDto.UpdatedAt != null)
        {
            generalTravelerInformationTpd.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return generalTravelerInformationTpd;
    }
}
