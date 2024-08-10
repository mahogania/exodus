using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class BondReleasesExtensions
{
    public static BondRelease ToDto(this BondReleaseDbModel model)
    {
        return new BondRelease
        {
            AmountReturnedAfterRelease = model.AmountReturnedAfterRelease,
            BondReleaseMoment = model.BondReleaseMoment,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FinalReleaseYn = model.FinalReleaseYn,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NumberOfBondReleases = model.NumberOfBondReleases,
            ReferenceNo = model.ReferenceNo,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            ReferenceNumberUsed = model.ReferenceNumberUsed,
            RequestNo = model.RequestNo,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static BondReleaseDbModel ToModel(
        this BondReleaseUpdateInput updateDto,
        BondReleaseWhereUniqueInput uniqueId
    )
    {
        var bondRelease = new BondReleaseDbModel
        {
            Id = uniqueId.Id,
            AmountReturnedAfterRelease = updateDto.AmountReturnedAfterRelease,
            BondReleaseMoment = updateDto.BondReleaseMoment,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FinalReleaseYn = updateDto.FinalReleaseYn,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NumberOfBondReleases = updateDto.NumberOfBondReleases,
            ReferenceNo = updateDto.ReferenceNo,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            ReferenceNumberUsed = updateDto.ReferenceNumberUsed,
            RequestNo = updateDto.RequestNo
        };

        if (updateDto.CreatedAt != null) bondRelease.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) bondRelease.UpdatedAt = updateDto.UpdatedAt.Value;

        return bondRelease;
    }
}
