using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class ReceiptsExtensions
{
    public static Receipt ToDto(this ReceiptDbModel model)
    {
        return new Receipt
        {
            CollectionNo = model.CollectionNo,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NoticeNo = model.NoticeNo,
            NumberOfIssuances = model.NumberOfIssuances,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static ReceiptDbModel ToModel(
        this ReceiptUpdateInput updateDto,
        ReceiptWhereUniqueInput uniqueId
    )
    {
        var receipt = new ReceiptDbModel
        {
            Id = uniqueId.Id,
            CollectionNo = updateDto.CollectionNo,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NoticeNo = updateDto.NoticeNo,
            NumberOfIssuances = updateDto.NumberOfIssuances
        };

        if (updateDto.CreatedAt != null) receipt.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) receipt.UpdatedAt = updateDto.UpdatedAt.Value;

        return receipt;
    }
}
