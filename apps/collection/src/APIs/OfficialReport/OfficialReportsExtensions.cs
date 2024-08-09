using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class OfficialReportsExtensions
{
    public static OfficialReport ToDto(this OfficialReportDbModel model)
    {
        return new OfficialReport
        {
            AccountingMaterialManagementNumber = model.AccountingMaterialManagementNumber,
            Address = model.Address,
            AdjudicatorIdentificationNumber = model.AdjudicatorIdentificationNumber,
            AdjudicatorIdentificationNumberTypeCode = model.AdjudicatorIdentificationNumberTypeCode,
            AdjudicatorSName = model.AdjudicatorSName,
            AlienationDate = model.AlienationDate,
            AttachedFileId = model.AttachedFileId,
            CreatedAt = model.CreatedAt,
            DecisionOfAssignmentNumber = model.DecisionOfAssignmentNumber,
            DeletionFlag = model.DeletionFlag,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            ItemSequenceNumber = model.ItemSequenceNumber,
            MinutesOfDefaultNumber = model.MinutesOfDefaultNumber,
            MinutesOfDefaultTypeCode = model.MinutesOfDefaultTypeCode,
            OfficeCode = model.OfficeCode,
            ReasonsForDefault = model.ReasonsForDefault,
            ReceiverId = model.ReceiverId,
            ReferenceNumber = model.ReferenceNumber,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = model.ReferenceNumberTypeName,
            RegistrationDate = model.RegistrationDate,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static OfficialReportDbModel ToModel(
        this OfficialReportUpdateInput updateDto,
        OfficialReportWhereUniqueInput uniqueId
    )
    {
        var officialReport = new OfficialReportDbModel
        {
            Id = uniqueId.Id,
            AccountingMaterialManagementNumber = updateDto.AccountingMaterialManagementNumber,
            Address = updateDto.Address,
            AdjudicatorIdentificationNumber = updateDto.AdjudicatorIdentificationNumber,
            AdjudicatorIdentificationNumberTypeCode =
                updateDto.AdjudicatorIdentificationNumberTypeCode,
            AdjudicatorSName = updateDto.AdjudicatorSName,
            AlienationDate = updateDto.AlienationDate,
            AttachedFileId = updateDto.AttachedFileId,
            DecisionOfAssignmentNumber = updateDto.DecisionOfAssignmentNumber,
            DeletionFlag = updateDto.DeletionFlag,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            ItemSequenceNumber = updateDto.ItemSequenceNumber,
            MinutesOfDefaultNumber = updateDto.MinutesOfDefaultNumber,
            MinutesOfDefaultTypeCode = updateDto.MinutesOfDefaultTypeCode,
            OfficeCode = updateDto.OfficeCode,
            ReasonsForDefault = updateDto.ReasonsForDefault,
            ReceiverId = updateDto.ReceiverId,
            ReferenceNumber = updateDto.ReferenceNumber,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = updateDto.ReferenceNumberTypeName,
            RegistrationDate = updateDto.RegistrationDate,
            ServiceCode = updateDto.ServiceCode
        };

        if (updateDto.CreatedAt != null)
        {
            officialReport.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            officialReport.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return officialReport;
    }
}
