using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class AccompaniedBaggageEntryAndExitsExtensions
{
    public static AccompaniedBaggageEntryAndExit ToDto(
        this AccompaniedBaggageEntryAndExitDbModel model
    )
    {
        return new AccompaniedBaggageEntryAndExit
        {
            BaggageNumber = model.BaggageNumber,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            DepositBulletinNumber = model.DepositBulletinNumber,
            EntryAndExitCategoryCode = model.EntryAndExitCategoryCode,
            ExitRequestDate = model.ExitRequestDate,
            ExitRequestTypeCode = model.ExitRequestTypeCode,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            Id = model.Id,
            OfficerId = model.OfficerId,
            PersonalEffectsClearanceNumber = model.PersonalEffectsClearanceNumber,
            RemovalDate = model.RemovalDate,
            StockQuantity = model.StockQuantity,
            StockWeight = model.StockWeight,
            TravelerName = model.TravelerName,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static AccompaniedBaggageEntryAndExitDbModel ToModel(
        this AccompaniedBaggageEntryAndExitUpdateInput updateDto,
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId
    )
    {
        var accompaniedBaggageEntryAndExit = new AccompaniedBaggageEntryAndExitDbModel
        {
            Id = uniqueId.Id,
            BaggageNumber = updateDto.BaggageNumber,
            DeletionOn = updateDto.DeletionOn,
            DepositBulletinNumber = updateDto.DepositBulletinNumber,
            EntryAndExitCategoryCode = updateDto.EntryAndExitCategoryCode,
            ExitRequestDate = updateDto.ExitRequestDate,
            ExitRequestTypeCode = updateDto.ExitRequestTypeCode,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            OfficerId = updateDto.OfficerId,
            PersonalEffectsClearanceNumber = updateDto.PersonalEffectsClearanceNumber,
            RemovalDate = updateDto.RemovalDate,
            StockQuantity = updateDto.StockQuantity,
            StockWeight = updateDto.StockWeight,
            TravelerName = updateDto.TravelerName
        };

        if (updateDto.CreatedAt != null)
        {
            accompaniedBaggageEntryAndExit.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            accompaniedBaggageEntryAndExit.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return accompaniedBaggageEntryAndExit;
    }
}
