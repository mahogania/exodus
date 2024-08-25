using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ShAnalyseCollectionTemporaire2sExtensions
{
    public static ShAnalyseCollectionTemporaire2 ToDto(
        this ShAnalyseCollectionTemporaire2DbModel model
    )
    {
        return new ShAnalyseCollectionTemporaire2
        {
            ClassementGroupesPrixNcyUnitaires = model.ClassementGroupesPrixNcyUnitaires,
            ClassementGroupesPrixUsdUnitaires = model.ClassementGroupesPrixUsdUnitaires,
            CodeSh = model.CodeSh,
            CreatedAt = model.CreatedAt,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            PremierEnregistrantId = model.PremierEnregistrantId,
            PrixNcyUnitaire = model.PrixNcyUnitaire,
            PrixUsdUnitaire = model.PrixUsdUnitaire,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ShAnalyseCollectionTemporaire2DbModel ToModel(
        this ShAnalyseCollectionTemporaire2UpdateInput updateDto,
        ShAnalyseCollectionTemporaire2WhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollectionTemporaire2 = new ShAnalyseCollectionTemporaire2DbModel
        {
            Id = uniqueId.Id,
            ClassementGroupesPrixNcyUnitaires = updateDto.ClassementGroupesPrixNcyUnitaires,
            ClassementGroupesPrixUsdUnitaires = updateDto.ClassementGroupesPrixUsdUnitaires,
            CodeSh = updateDto.CodeSh,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            PrixNcyUnitaire = updateDto.PrixNcyUnitaire,
            PrixUsdUnitaire = updateDto.PrixUsdUnitaire,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            shAnalyseCollectionTemporaire2.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            shAnalyseCollectionTemporaire2.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return shAnalyseCollectionTemporaire2;
    }
}
