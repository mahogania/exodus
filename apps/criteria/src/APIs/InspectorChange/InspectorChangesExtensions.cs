using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class InspectorChangesExtensions
{
    public static InspectorChange ToDto(this InspectorChangeDbModel model)
    {
        return new InspectorChange
        {
            CreatedAt = model.CreatedAt,
            DetailedDeclarationNumber = model.DetailedDeclarationNumber,
            Id = model.Id,
            InitialVerifierId = model.InitialVerifierId,
            InitialVisitOfficerId = model.InitialVisitOfficerId,
            InspectorChangeReasonCode = model.InspectorChangeReasonCode,
            ModificationDate = model.ModificationDate,
            ModificationNumber = model.ModificationNumber,
            ModificationResponsibleId = model.ModificationResponsibleId,
            NewInspectorId = model.NewInspectorId,
            NewVisitOfficerId = model.NewVisitOfficerId,
            ReasonForModification = model.ReasonForModification,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static InspectorChangeDbModel ToModel(
        this InspectorChangeUpdateInput updateDto,
        InspectorChangeWhereUniqueInput uniqueId
    )
    {
        var inspectorChange = new InspectorChangeDbModel
        {
            Id = uniqueId.Id,
            DetailedDeclarationNumber = updateDto.DetailedDeclarationNumber,
            InitialVerifierId = updateDto.InitialVerifierId,
            InitialVisitOfficerId = updateDto.InitialVisitOfficerId,
            InspectorChangeReasonCode = updateDto.InspectorChangeReasonCode,
            ModificationDate = updateDto.ModificationDate,
            ModificationNumber = updateDto.ModificationNumber,
            ModificationResponsibleId = updateDto.ModificationResponsibleId,
            NewInspectorId = updateDto.NewInspectorId,
            NewVisitOfficerId = updateDto.NewVisitOfficerId,
            ReasonForModification = updateDto.ReasonForModification
        };

        if (updateDto.CreatedAt != null)
        {
            inspectorChange.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            inspectorChange.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return inspectorChange;
    }
}
