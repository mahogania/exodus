using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class ProceduresExtensions
{
    public static Procedure ToDto(this ProcedureDbModel model)
    {
        return new Procedure
        {
            AttachedFileId = model.AttachedFileId,
            CreatedAt = model.CreatedAt,
            DeletionFlag = model.DeletionFlag,
            EtcYOrN = model.EtcYOrN,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            HandoverDate = model.HandoverDate,
            HandoverNoteNumber = model.HandoverNoteNumber,
            Id = model.Id,
            IncomingReceiverId = model.IncomingReceiverId,
            OfficeCode = model.OfficeCode,
            OtherContents = model.OtherContents,
            OutgoingReceiverId = model.OutgoingReceiverId,
            PhysicalInventoryOfEquipmentAndFurnitureYOrN =
                model.PhysicalInventoryOfEquipmentAndFurnitureYOrN,
            ServiceCode = model.ServiceCode,
            StateOfCashYOrN = model.StateOfCashYOrN,
            StateOfExpenseCertificatesStoppedYOrN = model.StateOfExpenseCertificatesStoppedYOrN,
            StateOfReceiptsStoppedYOrN = model.StateOfReceiptsStoppedYOrN,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ProcedureDbModel ToModel(
        this ProcedureUpdateInput updateDto,
        ProcedureWhereUniqueInput uniqueId
    )
    {
        var procedure = new ProcedureDbModel
        {
            Id = uniqueId.Id,
            AttachedFileId = updateDto.AttachedFileId,
            DeletionFlag = updateDto.DeletionFlag,
            EtcYOrN = updateDto.EtcYOrN,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            HandoverDate = updateDto.HandoverDate,
            HandoverNoteNumber = updateDto.HandoverNoteNumber,
            IncomingReceiverId = updateDto.IncomingReceiverId,
            OfficeCode = updateDto.OfficeCode,
            OtherContents = updateDto.OtherContents,
            OutgoingReceiverId = updateDto.OutgoingReceiverId,
            PhysicalInventoryOfEquipmentAndFurnitureYOrN =
                updateDto.PhysicalInventoryOfEquipmentAndFurnitureYOrN,
            ServiceCode = updateDto.ServiceCode,
            StateOfCashYOrN = updateDto.StateOfCashYOrN,
            StateOfExpenseCertificatesStoppedYOrN = updateDto.StateOfExpenseCertificatesStoppedYOrN,
            StateOfReceiptsStoppedYOrN = updateDto.StateOfReceiptsStoppedYOrN
        };

        if (updateDto.CreatedAt != null)
        {
            procedure.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            procedure.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return procedure;
    }
}
