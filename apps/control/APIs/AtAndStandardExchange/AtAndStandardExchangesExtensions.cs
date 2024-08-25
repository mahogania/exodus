using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class AtAndStandardExchangesExtensions
{
    public static AtAndStandardExchange ToDto(this AtAndStandardExchangeDbModel model)
    {
        return new AtAndStandardExchange
        {
            CreatedAt = model.CreatedAt,
            CustomsClearanceOfficeForAtEt = model.CustomsClearanceOfficeForAtEt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DateOfTheImportationDeclaration = model.DateOfTheImportationDeclaration,
            DeclarationNumber = model.DeclarationNumber,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            ImportationDeclarationCode = model.ImportationDeclarationCode,
            ReasonForTheRequest = model.ReasonForTheRequest,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            RequestStatus = model.RequestStatus,
            RequestedEndDate = model.RequestedEndDate,
            RequestedStartDate = model.RequestedStartDate,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
            WarrantyEndDate = model.WarrantyEndDate,
            WarrantyFrame = model.WarrantyFrame
        };
    }

    public static AtAndStandardExchangeDbModel ToModel(
        this AtAndStandardExchangeUpdateInput updateDto,
        AtAndStandardExchangeWhereUniqueInput uniqueId
    )
    {
        var atAndStandardExchange = new AtAndStandardExchangeDbModel
        {
            Id = uniqueId.Id,
            CustomsClearanceOfficeForAtEt = updateDto.CustomsClearanceOfficeForAtEt,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DateOfTheImportationDeclaration = updateDto.DateOfTheImportationDeclaration,
            DeclarationNumber = updateDto.DeclarationNumber,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            ImportationDeclarationCode = updateDto.ImportationDeclarationCode,
            ReasonForTheRequest = updateDto.ReasonForTheRequest,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            RequestStatus = updateDto.RequestStatus,
            RequestedEndDate = updateDto.RequestedEndDate,
            RequestedStartDate = updateDto.RequestedStartDate,
            SuppressionOn = updateDto.SuppressionOn,
            WarrantyEndDate = updateDto.WarrantyEndDate,
            WarrantyFrame = updateDto.WarrantyFrame
        };

        if (updateDto.CreatedAt != null) atAndStandardExchange.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) atAndStandardExchange.UpdatedAt = updateDto.UpdatedAt.Value;

        return atAndStandardExchange;
    }
}
