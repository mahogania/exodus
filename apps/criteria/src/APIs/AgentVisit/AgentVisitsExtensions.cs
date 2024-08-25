using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class AgentVisitsExtensions
{
    public static AgentVisit ToDto(this AgentVisitDbModel model)
    {
        return new AgentVisit
        {
            AgencyCode = model.AgencyCode,
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt,
            VerificationDate = model.VerificationDate,
            VerifierId = model.VerifierId,
        };
    }

    public static AgentVisitDbModel ToModel(
        this AgentVisitUpdateInput updateDto,
        AgentVisitWhereUniqueInput uniqueId
    )
    {
        var agentVisit = new AgentVisitDbModel
        {
            Id = uniqueId.Id,
            VerifierId = updateDto.VerifierId
        };

        if (updateDto.AgencyCode != null)
        {
            agentVisit.AgencyCode = updateDto.AgencyCode;
        }
        if (updateDto.CreatedAt != null)
        {
            agentVisit.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.ServiceCode != null)
        {
            agentVisit.ServiceCode = updateDto.ServiceCode;
        }
        if (updateDto.UpdatedAt != null)
        {
            agentVisit.UpdatedAt = updateDto.UpdatedAt.Value;
        }
        if (updateDto.VerificationDate != null)
        {
            agentVisit.VerificationDate = updateDto.VerificationDate.Value;
        }

        return agentVisit;
    }
}
