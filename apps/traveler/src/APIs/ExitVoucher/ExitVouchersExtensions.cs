using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class ExitVouchersExtensions
{
    public static ExitVoucher ToDto(this ExitVoucherDbModel model)
    {
        return new ExitVoucher
        {
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            ExitRequestDate = model.ExitRequestDate,
            ExitVoucherSerialNumber = model.ExitVoucherSerialNumber,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            Id = model.Id,
            OfficeCode = model.OfficeCode,
            ReferenceNumber = model.ReferenceNumber,
            UpdatedAt = model.UpdatedAt,
            VerifierId = model.VerifierId,
        };
    }

    public static ExitVoucherDbModel ToModel(
        this ExitVoucherUpdateInput updateDto,
        ExitVoucherWhereUniqueInput uniqueId
    )
    {
        var exitVoucher = new ExitVoucherDbModel
        {
            Id = uniqueId.Id,
            DeletionOn = updateDto.DeletionOn,
            ExitRequestDate = updateDto.ExitRequestDate,
            ExitVoucherSerialNumber = updateDto.ExitVoucherSerialNumber,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            OfficeCode = updateDto.OfficeCode,
            ReferenceNumber = updateDto.ReferenceNumber,
            VerifierId = updateDto.VerifierId
        };

        if (updateDto.CreatedAt != null)
        {
            exitVoucher.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            exitVoucher.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return exitVoucher;
    }
}
