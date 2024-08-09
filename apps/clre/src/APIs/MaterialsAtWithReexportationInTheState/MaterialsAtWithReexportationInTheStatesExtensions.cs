using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class MaterialsAtWithReexportationInTheStatesExtensions
{
    public static MaterialsAtWithReexportationInTheState ToDto(
        this MaterialsAtWithReexportationInTheStateDbModel model
    )
    {
        return new MaterialsAtWithReexportationInTheState
        {
            CommercialDesignationOfTheMaterials = model.CommercialDesignationOfTheMaterials,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            FobValueInCurrency = model.FobValueInCurrency,
            FobValueInDa = model.FobValueInDa,
            Id = model.Id,
            Identification = model.Identification,
            Origin = model.Origin,
            Quantity = model.Quantity,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            StateOfTheMaterialsAtTheTimeOfImportation =
                model.StateOfTheMaterialsAtTheTimeOfImportation,
            SuppressionOn = model.SuppressionOn,
            TechnicalDesignationOfTheMaterials = model.TechnicalDesignationOfTheMaterials,
            UnknownField = model.UnknownField,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static MaterialsAtWithReexportationInTheStateDbModel ToModel(
        this MaterialsAtWithReexportationInTheStateUpdateInput updateDto,
        MaterialsAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var materialsAtWithReexportationInTheState =
            new MaterialsAtWithReexportationInTheStateDbModel
            {
                Id = uniqueId.Id,
                CommercialDesignationOfTheMaterials = updateDto.CommercialDesignationOfTheMaterials,
                CurrencyCode = updateDto.CurrencyCode,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRegistrantSId = updateDto.FirstRegistrantSId,
                FobValueInCurrency = updateDto.FobValueInCurrency,
                FobValueInDa = updateDto.FobValueInDa,
                Identification = updateDto.Identification,
                Origin = updateDto.Origin,
                Quantity = updateDto.Quantity,
                RectificationFrequency = updateDto.RectificationFrequency,
                RegimeRequestNumber = updateDto.RegimeRequestNumber,
                SequenceNumber = updateDto.SequenceNumber,
                SptNumber = updateDto.SptNumber,
                StateOfTheMaterialsAtTheTimeOfImportation =
                    updateDto.StateOfTheMaterialsAtTheTimeOfImportation,
                SuppressionOn = updateDto.SuppressionOn,
                TechnicalDesignationOfTheMaterials = updateDto.TechnicalDesignationOfTheMaterials,
                UnknownField = updateDto.UnknownField
            };

        if (updateDto.CreatedAt != null)
        {
            materialsAtWithReexportationInTheState.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            materialsAtWithReexportationInTheState.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return materialsAtWithReexportationInTheState;
    }
}
