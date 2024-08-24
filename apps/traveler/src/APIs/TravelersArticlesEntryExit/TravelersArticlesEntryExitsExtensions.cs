using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class TravelersArticlesEntryExitsExtensions
{
    public static TravelersArticlesEntryExit ToDto(this TravelersArticlesEntryExitDbModel model)
    {
        return new TravelersArticlesEntryExit
        {
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            DepositedArticleSerialNumber = model.DepositedArticleSerialNumber,
            EntryAndExitCategoryCode = model.EntryAndExitCategoryCode,
            ExitedWeight = model.ExitedWeight,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            Id = model.Id,
            ImportDeclarations = model.ImportDeclarations?.Select(x => x.Id).ToList(),
            QuantityUnitCode = model.QuantityUnitCode,
            RemovalVoucherNumber = model.RemovalVoucherNumber,
            SectorCode = model.SectorCode,
            StockQuantity = model.StockQuantity,
            StockWeight = model.StockWeight,
            TravelerName = model.TravelerName,
            UpdatedAt = model.UpdatedAt,
            WeightUnit = model.WeightUnit,
        };
    }

    public static TravelersArticlesEntryExitDbModel ToModel(
        this TravelersArticlesEntryExitUpdateInput updateDto,
        TravelersArticlesEntryExitWhereUniqueInput uniqueId
    )
    {
        var travelersArticlesEntryExit = new TravelersArticlesEntryExitDbModel
        {
            Id = uniqueId.Id,
            DeletionOn = updateDto.DeletionOn,
            DepositedArticleSerialNumber = updateDto.DepositedArticleSerialNumber,
            EntryAndExitCategoryCode = updateDto.EntryAndExitCategoryCode,
            ExitedWeight = updateDto.ExitedWeight,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            QuantityUnitCode = updateDto.QuantityUnitCode,
            RemovalVoucherNumber = updateDto.RemovalVoucherNumber,
            SectorCode = updateDto.SectorCode,
            StockQuantity = updateDto.StockQuantity,
            StockWeight = updateDto.StockWeight,
            TravelerName = updateDto.TravelerName,
            WeightUnit = updateDto.WeightUnit
        };

        if (updateDto.CreatedAt != null)
        {
            travelersArticlesEntryExit.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            travelersArticlesEntryExit.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return travelersArticlesEntryExit;
    }
}
