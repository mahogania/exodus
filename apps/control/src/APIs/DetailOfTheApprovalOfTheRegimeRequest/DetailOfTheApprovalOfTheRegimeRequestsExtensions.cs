using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class DetailOfTheApprovalOfTheRegimeRequestsExtensions
{
    public static DetailOfTheApprovalOfTheRegimeRequest ToDto(
        this DetailOfTheApprovalOfTheRegimeRequestDbModel model
    )
    {
        return new DetailOfTheApprovalOfTheRegimeRequest
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

    public static DetailOfTheApprovalOfTheRegimeRequestDbModel ToModel(
        this DetailOfTheApprovalOfTheRegimeRequestUpdateInput updateDto,
        DetailOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    )
    {
        var detailOfTheApprovalOfTheRegimeRequest = new DetailOfTheApprovalOfTheRegimeRequestDbModel
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
            detailOfTheApprovalOfTheRegimeRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            detailOfTheApprovalOfTheRegimeRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return detailOfTheApprovalOfTheRegimeRequest;
    }
}
