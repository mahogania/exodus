using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class AppealsExtensions
{
    public static Appeal ToDto(this AppealDbModel model)
    {
        return new Appeal
        {
            AppealRequestContents = model.AppealRequestContents,
            AppealRequestResponseContents = model.AppealRequestResponseContents,
            CompetentCustomsOfficeCode = model.CompetentCustomsOfficeCode,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GeneralBondNote = model.GeneralBondNoteId,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            Id = model.Id,
            NumberOfAppeals = model.NumberOfAppeals,
            ReferenceNumber = model.ReferenceNumber,
            Reject = model.Reject,
            Remark = model.Remark,
            RequestDateAndTime = model.RequestDateAndTime,
            ResponseDateTime = model.ResponseDateTime,
            ResponsiblePersonId = model.ResponsiblePersonId,
            ResponsibleServiceCode = model.ResponsibleServiceCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static AppealDbModel ToModel(
        this AppealUpdateInput updateDto,
        AppealWhereUniqueInput uniqueId
    )
    {
        var appeal = new AppealDbModel
        {
            Id = uniqueId.Id,
            AppealRequestContents = updateDto.AppealRequestContents,
            AppealRequestResponseContents = updateDto.AppealRequestResponseContents,
            CompetentCustomsOfficeCode = updateDto.CompetentCustomsOfficeCode,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NumberOfAppeals = updateDto.NumberOfAppeals,
            ReferenceNumber = updateDto.ReferenceNumber,
            Reject = updateDto.Reject,
            Remark = updateDto.Remark,
            RequestDateAndTime = updateDto.RequestDateAndTime,
            ResponseDateTime = updateDto.ResponseDateTime,
            ResponsiblePersonId = updateDto.ResponsiblePersonId,
            ResponsibleServiceCode = updateDto.ResponsibleServiceCode
        };

        if (updateDto.CreatedAt != null)
        {
            appeal.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.GeneralBondNote != null)
        {
            appeal.GeneralBondNoteId = updateDto.GeneralBondNote;
        }
        if (updateDto.UpdatedAt != null)
        {
            appeal.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return appeal;
    }
}
