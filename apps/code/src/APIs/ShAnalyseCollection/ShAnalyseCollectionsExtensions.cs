using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ShAnalyseCollectionsExtensions
{
    public static ShAnalyseCollection ToDto(this ShAnalyseCollectionDbModel model)
    {
        return new ShAnalyseCollection
        {
            AnneeAddition = model.AnneeAddition,
            CodeChampPeriodeAddition = model.CodeChampPeriodeAddition,
            CodePaysOriginePrincipal = model.CodePaysOriginePrincipal,
            CodeSh = model.CodeSh,
            CreatedAt = model.CreatedAt,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            MoisAddition = model.MoisAddition,
            MontantNcyFacture = model.MontantNcyFacture,
            MontantNcyUniteMaximale = model.MontantNcyUniteMaximale,
            MontantNcyUniteMinimale = model.MontantNcyUniteMinimale,
            MontantUsdFacture = model.MontantUsdFacture,
            MontantUsdUniteMaximale = model.MontantUsdUniteMaximale,
            MontantUsdUniteMinimale = model.MontantUsdUniteMinimale,
            NombreCasArticles = model.NombreCasArticles,
            NombreDeclarations = model.NombreDeclarations,
            PremierEnregistrantId = model.PremierEnregistrantId,
            PrixUnitaireNcyEcartType = model.PrixUnitaireNcyEcartType,
            PrixUnitaireNcyLiquide = model.PrixUnitaireNcyLiquide,
            PrixUnitaireUsdEcartType = model.PrixUnitaireUsdEcartType,
            PrixUnitaireUsdLiquide = model.PrixUnitaireUsdLiquide,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ShAnalyseCollectionDbModel ToModel(
        this ShAnalyseCollectionUpdateInput updateDto,
        ShAnalyseCollectionWhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollection = new ShAnalyseCollectionDbModel
        {
            Id = uniqueId.Id,
            AnneeAddition = updateDto.AnneeAddition,
            CodeChampPeriodeAddition = updateDto.CodeChampPeriodeAddition,
            CodePaysOriginePrincipal = updateDto.CodePaysOriginePrincipal,
            CodeSh = updateDto.CodeSh,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            MoisAddition = updateDto.MoisAddition,
            MontantNcyFacture = updateDto.MontantNcyFacture,
            MontantNcyUniteMaximale = updateDto.MontantNcyUniteMaximale,
            MontantNcyUniteMinimale = updateDto.MontantNcyUniteMinimale,
            MontantUsdFacture = updateDto.MontantUsdFacture,
            MontantUsdUniteMaximale = updateDto.MontantUsdUniteMaximale,
            MontantUsdUniteMinimale = updateDto.MontantUsdUniteMinimale,
            NombreCasArticles = updateDto.NombreCasArticles,
            NombreDeclarations = updateDto.NombreDeclarations,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            PrixUnitaireNcyEcartType = updateDto.PrixUnitaireNcyEcartType,
            PrixUnitaireNcyLiquide = updateDto.PrixUnitaireNcyLiquide,
            PrixUnitaireUsdEcartType = updateDto.PrixUnitaireUsdEcartType,
            PrixUnitaireUsdLiquide = updateDto.PrixUnitaireUsdLiquide,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            shAnalyseCollection.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            shAnalyseCollection.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return shAnalyseCollection;
    }
}
