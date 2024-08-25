using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class PeriodeTarifNormalGeneralsExtensions
{
    public static PeriodeTarifNormalGeneral ToDto(this PeriodeTarifNormalGeneralDbModel model)
    {
        return new PeriodeTarifNormalGeneral
        {
            CreatedAt = model.CreatedAt,
            DateDebutApplication = model.DateDebutApplication,
            DateFinApplication = model.DateFinApplication,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            PremierEnregistrantId = model.PremierEnregistrantId,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static PeriodeTarifNormalGeneralDbModel ToModel(
        this PeriodeTarifNormalGeneralUpdateInput updateDto,
        PeriodeTarifNormalGeneralWhereUniqueInput uniqueId
    )
    {
        var periodeTarifNormalGeneral = new PeriodeTarifNormalGeneralDbModel
        {
            Id = uniqueId.Id,
            DateDebutApplication = updateDto.DateDebutApplication,
            DateFinApplication = updateDto.DateFinApplication,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            periodeTarifNormalGeneral.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            periodeTarifNormalGeneral.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return periodeTarifNormalGeneral;
    }
}
