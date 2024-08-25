using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ShAnalysePrixUnitairesExtensions
{
    public static ShAnalysePrixUnitaire ToDto(this ShAnalysePrixUnitaireDbModel model)
    {
        return new ShAnalysePrixUnitaire
        {
            CodePaysOrigine = model.CodePaysOrigine,
            CodeSh = model.CodeSh,
            CodeUniteQuantite = model.CodeUniteQuantite,
            CreatedAt = model.CreatedAt,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            DateValidation = model.DateValidation,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            MontantNcyFacture = model.MontantNcyFacture,
            MontantUsdFacture = model.MontantUsdFacture,
            NomMarque = model.NomMarque,
            NumeroArticle = model.NumeroArticle,
            NumeroDeclarationDetail = model.NumeroDeclarationDetail,
            NumeroIdentificationExportateur = model.NumeroIdentificationExportateur,
            NumeroIdentificationImportateur = model.NumeroIdentificationImportateur,
            PremierEnregistrantId = model.PremierEnregistrantId,
            PrixNcyUnitaire = model.PrixNcyUnitaire,
            PrixUsdUnitaire = model.PrixUsdUnitaire,
            Quantite = model.Quantite,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ShAnalysePrixUnitaireDbModel ToModel(
        this ShAnalysePrixUnitaireUpdateInput updateDto,
        ShAnalysePrixUnitaireWhereUniqueInput uniqueId
    )
    {
        var shAnalysePrixUnitaire = new ShAnalysePrixUnitaireDbModel
        {
            Id = uniqueId.Id,
            CodePaysOrigine = updateDto.CodePaysOrigine,
            CodeSh = updateDto.CodeSh,
            CodeUniteQuantite = updateDto.CodeUniteQuantite,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            DateValidation = updateDto.DateValidation,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            MontantNcyFacture = updateDto.MontantNcyFacture,
            MontantUsdFacture = updateDto.MontantUsdFacture,
            NomMarque = updateDto.NomMarque,
            NumeroArticle = updateDto.NumeroArticle,
            NumeroDeclarationDetail = updateDto.NumeroDeclarationDetail,
            NumeroIdentificationExportateur = updateDto.NumeroIdentificationExportateur,
            NumeroIdentificationImportateur = updateDto.NumeroIdentificationImportateur,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            PrixNcyUnitaire = updateDto.PrixNcyUnitaire,
            PrixUsdUnitaire = updateDto.PrixUsdUnitaire,
            Quantite = updateDto.Quantite,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            shAnalysePrixUnitaire.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            shAnalysePrixUnitaire.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return shAnalysePrixUnitaire;
    }
}
