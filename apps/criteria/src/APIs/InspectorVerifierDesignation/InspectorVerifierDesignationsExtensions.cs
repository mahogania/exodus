using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class InspectorVerifierDesignationsExtensions
{
    public static InspectorVerifierDesignation ToDto(this InspectorVerifierDesignationDbModel model)
    {
        return new InspectorVerifierDesignation
        {
            AgencyCode = model.AgencyCode,
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            InspectorId = model.InspectorId,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt,
            VerifierId = model.VerifierId,
        };
    }

    public static InspectorVerifierDesignationDbModel ToModel(
        this InspectorVerifierDesignationUpdateInput updateDto,
        InspectorVerifierDesignationWhereUniqueInput uniqueId
    )
    {
        var inspectorVerifierDesignation = new InspectorVerifierDesignationDbModel
        {
            Id = uniqueId.Id,
            VerifierId = updateDto.VerifierId
        };

        if (updateDto.AgencyCode != null)
        {
            inspectorVerifierDesignation.AgencyCode = updateDto.AgencyCode;
        }
        if (updateDto.CreatedAt != null)
        {
            inspectorVerifierDesignation.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.InspectorId != null)
        {
            inspectorVerifierDesignation.InspectorId = updateDto.InspectorId;
        }
        if (updateDto.ServiceCode != null)
        {
            inspectorVerifierDesignation.ServiceCode = updateDto.ServiceCode;
        }
        if (updateDto.UpdatedAt != null)
        {
            inspectorVerifierDesignation.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return inspectorVerifierDesignation;
    }
}
