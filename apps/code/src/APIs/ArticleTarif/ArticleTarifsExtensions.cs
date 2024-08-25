using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ArticleTarifsExtensions
{
    public static ArticleTarif ToDto(this ArticleTarifDbModel model)
    {
        return new ArticleTarif
        {
            CodeCategorieTarif = model.CodeCategorieTarif,
            CodeProduitNeufEtUsage = model.CodeProduitNeufEtUsage,
            CodeSh = model.CodeSh,
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

    public static ArticleTarifDbModel ToModel(
        this ArticleTarifUpdateInput updateDto,
        ArticleTarifWhereUniqueInput uniqueId
    )
    {
        var articleTarif = new ArticleTarifDbModel
        {
            Id = uniqueId.Id,
            CodeCategorieTarif = updateDto.CodeCategorieTarif,
            CodeProduitNeufEtUsage = updateDto.CodeProduitNeufEtUsage,
            CodeSh = updateDto.CodeSh,
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
            articleTarif.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            articleTarif.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return articleTarif;
    }
}
