using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class IssuancesExtensions
{
    public static Issuance ToDto(this IssuanceDbModel model)
    {
        return new Issuance
        {
            CollectionNo = model.CollectionNo,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            IssuingPersonId = model.IssuingPersonId,
            NumberOfIssuances = model.NumberOfIssuances,
            OfficeCode = model.OfficeCode,
            PublicationDate = model.PublicationDate,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static IssuanceDbModel ToModel(
        this IssuanceUpdateInput updateDto,
        IssuanceWhereUniqueInput uniqueId
    )
    {
        var issuance = new IssuanceDbModel
        {
            Id = uniqueId.Id,
            CollectionNo = updateDto.CollectionNo,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            IssuingPersonId = updateDto.IssuingPersonId,
            NumberOfIssuances = updateDto.NumberOfIssuances,
            OfficeCode = updateDto.OfficeCode,
            PublicationDate = updateDto.PublicationDate,
            ServiceCode = updateDto.ServiceCode
        };

        if (updateDto.CreatedAt != null)
        {
            issuance.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            issuance.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return issuance;
    }
}
