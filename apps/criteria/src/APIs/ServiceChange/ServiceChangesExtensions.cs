using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class ServiceChangesExtensions
{
    public static ServiceChange ToDto(this ServiceChangeDbModel model)
    {
        return new ServiceChange
        {
            CreatedAt = model.CreatedAt,
            DetailedDeclarationNumber = model.DetailedDeclarationNumber,
            Id = model.Id,
            InitialServiceCode = model.InitialServiceCode,
            ModificationDate = model.ModificationDate,
            ModificationNumber = model.ModificationNumber,
            ModificationResponsibleId = model.ModificationResponsibleId,
            NewServiceCode = model.NewServiceCode,
            ReasonForModification = model.ReasonForModification,
            ServiceChangeReasonCode = model.ServiceChangeReasonCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ServiceChangeDbModel ToModel(
        this ServiceChangeUpdateInput updateDto,
        ServiceChangeWhereUniqueInput uniqueId
    )
    {
        var serviceChange = new ServiceChangeDbModel
        {
            Id = uniqueId.Id,
            DetailedDeclarationNumber = updateDto.DetailedDeclarationNumber,
            InitialServiceCode = updateDto.InitialServiceCode,
            ModificationDate = updateDto.ModificationDate,
            ModificationNumber = updateDto.ModificationNumber,
            ModificationResponsibleId = updateDto.ModificationResponsibleId,
            NewServiceCode = updateDto.NewServiceCode,
            ReasonForModification = updateDto.ReasonForModification,
            ServiceChangeReasonCode = updateDto.ServiceChangeReasonCode
        };

        if (updateDto.CreatedAt != null)
        {
            serviceChange.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            serviceChange.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return serviceChange;
    }
}
