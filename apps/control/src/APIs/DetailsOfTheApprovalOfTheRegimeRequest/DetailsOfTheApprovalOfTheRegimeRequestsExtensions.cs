using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class DetailsOfTheApprovalOfTheRegimeRequestsExtensions
{
    public static DetailsOfTheApprovalOfTheRegimeRequest ToDto(
        this DetailsOfTheApprovalOfTheRegimeRequestDbModel model
    )
    {
        return new DetailsOfTheApprovalOfTheRegimeRequest
        {
            BrandName = model.BrandName,
            ChassisNumber = model.ChassisNumber,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            Price = model.Price,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            RegistrationNumber = model.RegistrationNumber,
            SequenceNumber = model.SequenceNumber,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
            VehicleModelName = model.VehicleModelName,
            VehiclePower = model.VehiclePower,
        };
    }

    public static DetailsOfTheApprovalOfTheRegimeRequestDbModel ToModel(
        this DetailsOfTheApprovalOfTheRegimeRequestUpdateInput updateDto,
        DetailsOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    )
    {
        var detailsOfTheApprovalOfTheRegimeRequest =
            new DetailsOfTheApprovalOfTheRegimeRequestDbModel
            {
                Id = uniqueId.Id,
                BrandName = updateDto.BrandName,
                ChassisNumber = updateDto.ChassisNumber,
                CurrencyCode = updateDto.CurrencyCode,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRegistrantSId = updateDto.FirstRegistrantSId,
                Price = updateDto.Price,
                RectificationFrequency = updateDto.RectificationFrequency,
                RegimeRequestNumber = updateDto.RegimeRequestNumber,
                RegistrationNumber = updateDto.RegistrationNumber,
                SequenceNumber = updateDto.SequenceNumber,
                SuppressionOn = updateDto.SuppressionOn,
                VehicleModelName = updateDto.VehicleModelName,
                VehiclePower = updateDto.VehiclePower
            };

        if (updateDto.CreatedAt != null)
        {
            detailsOfTheApprovalOfTheRegimeRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            detailsOfTheApprovalOfTheRegimeRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return detailsOfTheApprovalOfTheRegimeRequest;
    }
}
