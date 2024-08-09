using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class NoticeCancellationsExtensions
{
    public static NoticeCancellation ToDto(this NoticeCancellationDbModel model)
    {
        return new NoticeCancellation
        {
            AttachmentId = model.AttachmentId,
            CancellationDate = model.CancellationDate,
            CancellationReasonContent = model.CancellationReasonContent,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NoticeCancellationRequestNo = model.NoticeCancellationRequestNo,
            NoticeNo = model.NoticeNo,
            OfficeCode = model.OfficeCode,
            RegisteringPersonId = model.RegisteringPersonId,
            RegistrationDate = model.RegistrationDate,
            RequestOrderNo = model.RequestOrderNo,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static NoticeCancellationDbModel ToModel(
        this NoticeCancellationUpdateInput updateDto,
        NoticeCancellationWhereUniqueInput uniqueId
    )
    {
        var noticeCancellation = new NoticeCancellationDbModel
        {
            Id = uniqueId.Id,
            AttachmentId = updateDto.AttachmentId,
            CancellationDate = updateDto.CancellationDate,
            CancellationReasonContent = updateDto.CancellationReasonContent,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NoticeCancellationRequestNo = updateDto.NoticeCancellationRequestNo,
            NoticeNo = updateDto.NoticeNo,
            OfficeCode = updateDto.OfficeCode,
            RegisteringPersonId = updateDto.RegisteringPersonId,
            RegistrationDate = updateDto.RegistrationDate,
            RequestOrderNo = updateDto.RequestOrderNo,
            ServiceCode = updateDto.ServiceCode
        };

        if (updateDto.CreatedAt != null)
        {
            noticeCancellation.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            noticeCancellation.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return noticeCancellation;
    }
}
