using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class PeriodeTarifSpecialGeneralsExtensions
{
    public static PeriodeTarifSpecialGeneral ToDto(this PeriodeTarifSpecialGeneralDbModel model)
    {
        return new PeriodeTarifSpecialGeneral
        {
            CreatedAt = model.CreatedAt,
            DateDebutApplication = model.DateDebutApplication,
            DateFinApplication = model.DateFinApplication,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static PeriodeTarifSpecialGeneralDbModel ToModel(
        this PeriodeTarifSpecialGeneralUpdateInput updateDto,
        PeriodeTarifSpecialGeneralWhereUniqueInput uniqueId
    )
    {
        var periodeTarifSpecialGeneral = new PeriodeTarifSpecialGeneralDbModel
        {
            Id = uniqueId.Id,
            DateDebutApplication = updateDto.DateDebutApplication,
            DateFinApplication = updateDto.DateFinApplication
        };

        if (updateDto.CreatedAt != null)
        {
            periodeTarifSpecialGeneral.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            periodeTarifSpecialGeneral.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return periodeTarifSpecialGeneral;
    }
}
