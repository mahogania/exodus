using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class WarehouseTransferPublicPrivatesExtensions
{
    public static WarehouseTransferPublicPrivate ToDto(
        this WarehouseTransferPublicPrivateDbModel model
    )
    {
        return new WarehouseTransferPublicPrivate
        {
            Address = model.Address,
            ApcCode = model.ApcCode,
            CreatedAt = model.CreatedAt,
            CustomsClearanceOfficeOfDeclaration = model.CustomsClearanceOfficeOfDeclaration,
            CustomsClearanceOfficeOfTheOperation = model.CustomsClearanceOfficeOfTheOperation,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeclarationDate = model.DeclarationDate,
            DeclarationNumber = model.DeclarationNumber,
            DesignationOfTheSubCustomsZone = model.DesignationOfTheSubCustomsZone,
            EpcCode = model.EpcCode,
            ExpiryDate = model.ExpiryDate,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            ImporterSAddress = model.ImporterSAddress,
            ImporterSName = model.ImporterSName,
            LabelApc = model.LabelApc,
            LabelEpc = model.LabelEpc,
            NameAndBusinessName = model.NameAndBusinessName,
            Nif = model.Nif,
            NifStatus = model.NifStatus,
            NumberOfArticles = model.NumberOfArticles,
            NumberOfTheImporterSTradeRegister = model.NumberOfTheImporterSTradeRegister,
            PurposeOfTheRequest = model.PurposeOfTheRequest,
            RcStatus = model.RcStatus,
            ReasonForTheRequest = model.ReasonForTheRequest,
            RectificationFrequency = model.RectificationFrequency,
            RequestNumberOfRegime = model.RequestNumberOfRegime,
            RequestedEndDate = model.RequestedEndDate,
            RequestedStartDate = model.RequestedStartDate,
            SuppressionOn = model.SuppressionOn,
            TradeRegisterNumberOfTheImporter = model.TradeRegisterNumberOfTheImporter,
            TypeOfTheSubCustomsZone = model.TypeOfTheSubCustomsZone,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static WarehouseTransferPublicPrivateDbModel ToModel(
        this WarehouseTransferPublicPrivateUpdateInput updateDto,
        WarehouseTransferPublicPrivateWhereUniqueInput uniqueId
    )
    {
        var warehouseTransferPublicPrivate = new WarehouseTransferPublicPrivateDbModel
        {
            Id = uniqueId.Id,
            Address = updateDto.Address,
            ApcCode = updateDto.ApcCode,
            CustomsClearanceOfficeOfDeclaration = updateDto.CustomsClearanceOfficeOfDeclaration,
            CustomsClearanceOfficeOfTheOperation = updateDto.CustomsClearanceOfficeOfTheOperation,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeclarationDate = updateDto.DeclarationDate,
            DeclarationNumber = updateDto.DeclarationNumber,
            DesignationOfTheSubCustomsZone = updateDto.DesignationOfTheSubCustomsZone,
            EpcCode = updateDto.EpcCode,
            ExpiryDate = updateDto.ExpiryDate,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            ImporterSAddress = updateDto.ImporterSAddress,
            ImporterSName = updateDto.ImporterSName,
            LabelApc = updateDto.LabelApc,
            LabelEpc = updateDto.LabelEpc,
            NameAndBusinessName = updateDto.NameAndBusinessName,
            Nif = updateDto.Nif,
            NifStatus = updateDto.NifStatus,
            NumberOfArticles = updateDto.NumberOfArticles,
            NumberOfTheImporterSTradeRegister = updateDto.NumberOfTheImporterSTradeRegister,
            PurposeOfTheRequest = updateDto.PurposeOfTheRequest,
            RcStatus = updateDto.RcStatus,
            ReasonForTheRequest = updateDto.ReasonForTheRequest,
            RectificationFrequency = updateDto.RectificationFrequency,
            RequestNumberOfRegime = updateDto.RequestNumberOfRegime,
            RequestedEndDate = updateDto.RequestedEndDate,
            RequestedStartDate = updateDto.RequestedStartDate,
            SuppressionOn = updateDto.SuppressionOn,
            TradeRegisterNumberOfTheImporter = updateDto.TradeRegisterNumberOfTheImporter,
            TypeOfTheSubCustomsZone = updateDto.TypeOfTheSubCustomsZone
        };

        if (updateDto.CreatedAt != null)
        {
            warehouseTransferPublicPrivate.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            warehouseTransferPublicPrivate.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return warehouseTransferPublicPrivate;
    }
}
