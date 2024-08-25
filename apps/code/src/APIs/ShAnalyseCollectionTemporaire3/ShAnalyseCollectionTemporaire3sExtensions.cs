using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ShAnalyseCollectionTemporaire3sExtensions
{
    public static ShAnalyseCollectionTemporaire3 ToDto(
        this ShAnalyseCollectionTemporaire3DbModel model
    )
    {
        return new ShAnalyseCollectionTemporaire3
        {
            CodeSh = model.CodeSh,
            CreatedAt = model.CreatedAt,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            PremierEnregistrantId = model.PremierEnregistrantId,
            PrixUnitaireNcyMinimum = model.PrixUnitaireNcyMinimum,
            PrixUnitaireNcyPlafonne = model.PrixUnitaireNcyPlafonne,
            PrixUnitaireUsdMinimum = model.PrixUnitaireUsdMinimum,
            PrixUnitaireUsdPlafonne = model.PrixUnitaireUsdPlafonne,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ShAnalyseCollectionTemporaire3DbModel ToModel(
        this ShAnalyseCollectionTemporaire3UpdateInput updateDto,
        ShAnalyseCollectionTemporaire3WhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollectionTemporaire3 = new ShAnalyseCollectionTemporaire3DbModel
        {
            Id = uniqueId.Id,
            CodeSh = updateDto.CodeSh,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            PrixUnitaireNcyMinimum = updateDto.PrixUnitaireNcyMinimum,
            PrixUnitaireNcyPlafonne = updateDto.PrixUnitaireNcyPlafonne,
            PrixUnitaireUsdMinimum = updateDto.PrixUnitaireUsdMinimum,
            PrixUnitaireUsdPlafonne = updateDto.PrixUnitaireUsdPlafonne,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            shAnalyseCollectionTemporaire3.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            shAnalyseCollectionTemporaire3.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return shAnalyseCollectionTemporaire3;
    }
}
