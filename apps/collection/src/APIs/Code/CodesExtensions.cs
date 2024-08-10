using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class CodesExtensions
{
    public static Code ToDto(this CodeDbModel model)
    {
        return new Code
        {
            CappedAmount = model.CappedAmount,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FineRelatedTaxCode = model.FineRelatedTaxCode,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            FloorAmount = model.FloorAmount,
            Id = model.Id,
            InfractionCode = model.InfractionCode,
            InfractionCodeDescription = model.InfractionCodeDescription,
            InfractionCodeDetails = model.InfractionCodeDetails,
            InfractionCodeLabel = model.InfractionCodeLabel,
            OperationTypeCode = model.OperationTypeCode,
            UpdatedAt = model.UpdatedAt,
            UsedOn = model.UsedOn
        };
    }

    public static CodeDbModel ToModel(this CodeUpdateInput updateDto, CodeWhereUniqueInput uniqueId)
    {
        var code = new CodeDbModel
        {
            Id = uniqueId.Id,
            CappedAmount = updateDto.CappedAmount,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FineRelatedTaxCode = updateDto.FineRelatedTaxCode,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            FloorAmount = updateDto.FloorAmount,
            InfractionCode = updateDto.InfractionCode,
            InfractionCodeDescription = updateDto.InfractionCodeDescription,
            InfractionCodeDetails = updateDto.InfractionCodeDetails,
            InfractionCodeLabel = updateDto.InfractionCodeLabel,
            OperationTypeCode = updateDto.OperationTypeCode,
            UsedOn = updateDto.UsedOn
        };

        if (updateDto.CreatedAt != null) code.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) code.UpdatedAt = updateDto.UpdatedAt.Value;

        return code;
    }
}
