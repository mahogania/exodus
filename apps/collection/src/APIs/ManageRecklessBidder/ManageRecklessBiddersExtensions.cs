using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class ManageRecklessBiddersExtensions
{
    public static ManageRecklessBidder ToDto(this ManageRecklessBidderDbModel model)
    {
        return new ManageRecklessBidder
        {
            BidderIdentificationNo = model.BidderIdentificationNo,
            BidderIdentificationNoTypeCode = model.BidderIdentificationNoTypeCode,
            BidderName = model.BidderName,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            DetailSequenceNo = model.DetailSequenceNo,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            LotNo = model.LotNo,
            OfficeCode = model.OfficeCode,
            RegistrationPersonIdentifier = model.RegistrationPersonIdentifier,
            RemarkContent = model.RemarkContent,
            SalePvNo = model.SalePvNo,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static ManageRecklessBidderDbModel ToModel(
        this ManageRecklessBidderUpdateInput updateDto,
        ManageRecklessBidderWhereUniqueInput uniqueId
    )
    {
        var manageRecklessBidder = new ManageRecklessBidderDbModel
        {
            Id = uniqueId.Id,
            BidderIdentificationNo = updateDto.BidderIdentificationNo,
            BidderIdentificationNoTypeCode = updateDto.BidderIdentificationNoTypeCode,
            BidderName = updateDto.BidderName,
            DeletionOn = updateDto.DeletionOn,
            DetailSequenceNo = updateDto.DetailSequenceNo,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            LotNo = updateDto.LotNo,
            OfficeCode = updateDto.OfficeCode,
            RegistrationPersonIdentifier = updateDto.RegistrationPersonIdentifier,
            RemarkContent = updateDto.RemarkContent,
            SalePvNo = updateDto.SalePvNo,
            ServiceCode = updateDto.ServiceCode
        };

        if (updateDto.CreatedAt != null) manageRecklessBidder.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) manageRecklessBidder.UpdatedAt = updateDto.UpdatedAt.Value;

        return manageRecklessBidder;
    }
}
