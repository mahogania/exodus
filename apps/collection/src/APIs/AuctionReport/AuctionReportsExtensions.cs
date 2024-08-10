using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class AuctionReportsExtensions
{
    public static AuctionReport ToDto(this AuctionReportDbModel model)
    {
        return new AuctionReport
        {
            Address = model.Address,
            AmountInWords = model.AmountInWords,
            AttachedFileId = model.AttachedFileId,
            AuctionDate = model.AuctionDate,
            AuctionDateAndTime = model.AuctionDateAndTime,
            AuctionLocation = model.AuctionLocation,
            AuctionValidationOfficerId = model.AuctionValidationOfficerId,
            BuyerIdentificationNumber = model.BuyerIdentificationNumber,
            BuyerIdentificationTypeCode = model.BuyerIdentificationTypeCode,
            BuyerName = model.BuyerName,
            CommercialRegisterNumber = model.CommercialRegisterNumber,
            ContainerNumber = model.ContainerNumber,
            CreatedAt = model.CreatedAt,
            DeletionFlag = model.DeletionFlag,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            InventoryManagementNumber = model.InventoryManagementNumber,
            ItemSequenceNumber = model.ItemSequenceNumber,
            LotNumber = model.LotNumber,
            MerchandiseDescription = model.MerchandiseDescription,
            NetProceeds = model.NetProceeds,
            OfficeCode = model.OfficeCode,
            Quantity = model.Quantity,
            ReceiptDate = model.ReceiptDate,
            ReceiptNumber = model.ReceiptNumber,
            RegistrationDate = model.RegistrationDate,
            RegistrationFee = model.RegistrationFee,
            RemarksContent = model.RemarksContent,
            SaleReportNumber = model.SaleReportNumber,
            ServiceCode = model.ServiceCode,
            TotalAmount = model.TotalAmount,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static AuctionReportDbModel ToModel(
        this AuctionReportUpdateInput updateDto,
        AuctionReportWhereUniqueInput uniqueId
    )
    {
        var auctionReport = new AuctionReportDbModel
        {
            Id = uniqueId.Id,
            Address = updateDto.Address,
            AmountInWords = updateDto.AmountInWords,
            AttachedFileId = updateDto.AttachedFileId,
            AuctionDate = updateDto.AuctionDate,
            AuctionDateAndTime = updateDto.AuctionDateAndTime,
            AuctionLocation = updateDto.AuctionLocation,
            AuctionValidationOfficerId = updateDto.AuctionValidationOfficerId,
            BuyerIdentificationNumber = updateDto.BuyerIdentificationNumber,
            BuyerIdentificationTypeCode = updateDto.BuyerIdentificationTypeCode,
            BuyerName = updateDto.BuyerName,
            CommercialRegisterNumber = updateDto.CommercialRegisterNumber,
            ContainerNumber = updateDto.ContainerNumber,
            DeletionFlag = updateDto.DeletionFlag,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            InventoryManagementNumber = updateDto.InventoryManagementNumber,
            ItemSequenceNumber = updateDto.ItemSequenceNumber,
            LotNumber = updateDto.LotNumber,
            MerchandiseDescription = updateDto.MerchandiseDescription,
            NetProceeds = updateDto.NetProceeds,
            OfficeCode = updateDto.OfficeCode,
            Quantity = updateDto.Quantity,
            ReceiptDate = updateDto.ReceiptDate,
            ReceiptNumber = updateDto.ReceiptNumber,
            RegistrationDate = updateDto.RegistrationDate,
            RegistrationFee = updateDto.RegistrationFee,
            RemarksContent = updateDto.RemarksContent,
            SaleReportNumber = updateDto.SaleReportNumber,
            ServiceCode = updateDto.ServiceCode,
            TotalAmount = updateDto.TotalAmount
        };

        if (updateDto.CreatedAt != null) auctionReport.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) auctionReport.UpdatedAt = updateDto.UpdatedAt.Value;

        return auctionReport;
    }
}
