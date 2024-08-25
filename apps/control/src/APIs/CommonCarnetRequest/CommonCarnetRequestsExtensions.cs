using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CommonCarnetRequestsExtensions
{
    public static CommonCarnetRequest ToDto(this CommonCarnetRequestDbModel model)
    {
        return new CommonCarnetRequest
        {
            ArticleCarnetRequests = model.ArticleCarnetRequests?.Select(x => x.Id).ToList(),
            AttachedFileId = model.AttachedFileId,
            CarnetControls = model.CarnetControls?.Select(x => x.Id).ToList(),
            CertificationOrganization = model.CertificationOrganization,
            CreatedAt = model.CreatedAt,
            CustomsOfficeCode = model.CustomsOfficeCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeletionOn = model.DeletionOn,
            DepartureCountryCode = model.DepartureCountryCode,
            DepartureCountryCode_1 = model.DepartureCountryCode_1,
            DepartureCountryCode_2 = model.DepartureCountryCode_2,
            DepartureCountryCode_3 = model.DepartureCountryCode_3,
            DepartureOfficeCode_2 = model.DepartureOfficeCode_2,
            DepartureOfficeCode_3 = model.DepartureOfficeCode_3,
            DepartureOffice_1 = model.DepartureOffice_1,
            DepartureOffice_2 = model.DepartureOffice_2,
            DepartureOffice_3 = model.DepartureOffice_3,
            DestinationCountryCode = model.DestinationCountryCode,
            DestinationCountryCode_1 = model.DestinationCountryCode_1,
            DestinationCountryCode_2 = model.DestinationCountryCode_2,
            DestinationCountryCode_3 = model.DestinationCountryCode_3,
            DestinationOfficeCode_1 = model.DestinationOfficeCode_1,
            DestinationOfficeCode_2 = model.DestinationOfficeCode_2,
            DestinationOfficeCode_3 = model.DestinationOfficeCode_3,
            DestinationOffice_1 = model.DestinationOffice_1,
            DestinationOffice_2 = model.DestinationOffice_2,
            DestinationOffice_3 = model.DestinationOffice_3,
            Destination_1TransportQuantity = model.Destination_1TransportQuantity,
            Destination_2TransportQuantity = model.Destination_2TransportQuantity,
            Destination_3TransportQuantity = model.Destination_3TransportQuantity,
            ExtendedPeriodCarnetRequests = model
                .ExtendedPeriodCarnetRequests?.Select(x => x.Id)
                .ToList(),
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            HolderSAddress = model.HolderSAddress,
            HolderSIdentificationNumber = model.HolderSIdentificationNumber,
            HolderSName = model.HolderSName,
            HolderSZipcode = model.HolderSZipcode,
            Id = model.Id,
            ImportCarnetRequests = model.ImportCarnetRequests?.Select(x => x.Id).ToList(),
            InternationalOrganizationName = model.InternationalOrganizationName,
            IssueDate = model.IssueDate,
            IssuedBy = model.IssuedBy,
            NumberOfContainerConcerned = model.NumberOfContainerConcerned,
            Observations = model.Observations,
            OfficialUse = model.OfficialUse,
            ReexportCarnetRequests = model.ReexportCarnetRequests?.Select(x => x.Id).ToList(),
            RegistrationDate = model.RegistrationDate,
            RegistrationNumber = model.RegistrationNumber,
            SealNumber = model.SealNumber,
            StatusProcessingCode = model.StatusProcessingCode,
            TirNumber = model.TirNumber,
            TirRegistrationNumber = model.TirRegistrationNumber,
            TotalNumberOfGoods = model.TotalNumberOfGoods,
            TransitCarnetRequests = model.TransitCarnetRequests?.Select(x => x.Id).ToList(),
            UpdatedAt = model.UpdatedAt,
            ValidUntil = model.ValidUntil,
            VehicleCertificationNoAndDate = model.VehicleCertificationNoAndDate,
        };
    }

    public static CommonCarnetRequestDbModel ToModel(
        this CommonCarnetRequestUpdateInput updateDto,
        CommonCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var commonCarnetRequest = new CommonCarnetRequestDbModel
        {
            Id = uniqueId.Id,
            AttachedFileId = updateDto.AttachedFileId,
            CertificationOrganization = updateDto.CertificationOrganization,
            CustomsOfficeCode = updateDto.CustomsOfficeCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeletionOn = updateDto.DeletionOn,
            DepartureCountryCode = updateDto.DepartureCountryCode,
            DepartureCountryCode_1 = updateDto.DepartureCountryCode_1,
            DepartureCountryCode_2 = updateDto.DepartureCountryCode_2,
            DepartureCountryCode_3 = updateDto.DepartureCountryCode_3,
            DepartureOfficeCode_2 = updateDto.DepartureOfficeCode_2,
            DepartureOfficeCode_3 = updateDto.DepartureOfficeCode_3,
            DepartureOffice_1 = updateDto.DepartureOffice_1,
            DepartureOffice_2 = updateDto.DepartureOffice_2,
            DepartureOffice_3 = updateDto.DepartureOffice_3,
            DestinationCountryCode = updateDto.DestinationCountryCode,
            DestinationCountryCode_1 = updateDto.DestinationCountryCode_1,
            DestinationCountryCode_2 = updateDto.DestinationCountryCode_2,
            DestinationCountryCode_3 = updateDto.DestinationCountryCode_3,
            DestinationOfficeCode_1 = updateDto.DestinationOfficeCode_1,
            DestinationOfficeCode_2 = updateDto.DestinationOfficeCode_2,
            DestinationOfficeCode_3 = updateDto.DestinationOfficeCode_3,
            DestinationOffice_1 = updateDto.DestinationOffice_1,
            DestinationOffice_2 = updateDto.DestinationOffice_2,
            DestinationOffice_3 = updateDto.DestinationOffice_3,
            Destination_1TransportQuantity = updateDto.Destination_1TransportQuantity,
            Destination_2TransportQuantity = updateDto.Destination_2TransportQuantity,
            Destination_3TransportQuantity = updateDto.Destination_3TransportQuantity,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            HolderSAddress = updateDto.HolderSAddress,
            HolderSIdentificationNumber = updateDto.HolderSIdentificationNumber,
            HolderSName = updateDto.HolderSName,
            HolderSZipcode = updateDto.HolderSZipcode,
            InternationalOrganizationName = updateDto.InternationalOrganizationName,
            IssueDate = updateDto.IssueDate,
            IssuedBy = updateDto.IssuedBy,
            NumberOfContainerConcerned = updateDto.NumberOfContainerConcerned,
            Observations = updateDto.Observations,
            OfficialUse = updateDto.OfficialUse,
            RegistrationDate = updateDto.RegistrationDate,
            RegistrationNumber = updateDto.RegistrationNumber,
            SealNumber = updateDto.SealNumber,
            StatusProcessingCode = updateDto.StatusProcessingCode,
            TirNumber = updateDto.TirNumber,
            TirRegistrationNumber = updateDto.TirRegistrationNumber,
            TotalNumberOfGoods = updateDto.TotalNumberOfGoods,
            ValidUntil = updateDto.ValidUntil,
            VehicleCertificationNoAndDate = updateDto.VehicleCertificationNoAndDate
        };

        if (updateDto.CreatedAt != null)
        {
            commonCarnetRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            commonCarnetRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return commonCarnetRequest;
    }
}
