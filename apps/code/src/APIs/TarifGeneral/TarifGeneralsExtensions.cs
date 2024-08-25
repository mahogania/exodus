using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class TarifGeneralsExtensions
{
    public static TarifGeneral ToDto(this TarifGeneralDbModel model)
    {
        return new TarifGeneral
        {
            CodeCategorieTarif = model.CodeCategorieTarif,
            CodeTypeTarif = model.CodeTypeTarif,
            CreatedAt = model.CreatedAt,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            DetailsDroitsAdValoremCommeBaseTaxable = model.DetailsDroitsAdValoremCommeBaseTaxable,
            DetailsDroitsSpecifiquesCommeBaseTaxable =
                model.DetailsDroitsSpecifiquesCommeBaseTaxable,
            DetailsTarifAdValorem = model.DetailsTarifAdValorem,
            DetailsTarifSpecifique = model.DetailsTarifSpecifique,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            PremierEnregistrantId = model.PremierEnregistrantId,
            Sequence = model.Sequence,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
            UtiliseOn = model.UtiliseOn,
        };
    }

    public static TarifGeneralDbModel ToModel(
        this TarifGeneralUpdateInput updateDto,
        TarifGeneralWhereUniqueInput uniqueId
    )
    {
        var tarifGeneral = new TarifGeneralDbModel
        {
            Id = uniqueId.Id,
            CodeCategorieTarif = updateDto.CodeCategorieTarif,
            CodeTypeTarif = updateDto.CodeTypeTarif,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            DetailsDroitsAdValoremCommeBaseTaxable =
                updateDto.DetailsDroitsAdValoremCommeBaseTaxable,
            DetailsDroitsSpecifiquesCommeBaseTaxable =
                updateDto.DetailsDroitsSpecifiquesCommeBaseTaxable,
            DetailsTarifAdValorem = updateDto.DetailsTarifAdValorem,
            DetailsTarifSpecifique = updateDto.DetailsTarifSpecifique,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            Sequence = updateDto.Sequence,
            SuppressionOn = updateDto.SuppressionOn,
            UtiliseOn = updateDto.UtiliseOn
        };

        if (updateDto.CreatedAt != null)
        {
            tarifGeneral.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            tarifGeneral.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return tarifGeneral;
    }
}
