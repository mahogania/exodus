using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class PrixUnitaireDeclarationDetailsExtensions
{
    public static PrixUnitaireDeclarationDetail ToDto(
        this PrixUnitaireDeclarationDetailDbModel model
    )
    {
        return new PrixUnitaireDeclarationDetail
        {
            CodeDevise = model.CodeDevise,
            CodeMethodeEvaluationValeur = model.CodeMethodeEvaluationValeur,
            CodePaysExpedition = model.CodePaysExpedition,
            CodePaysOrigine = model.CodePaysOrigine,
            CodeProduitNeufEtUsage = model.CodeProduitNeufEtUsage,
            CodeShDeclare = model.CodeShDeclare,
            CodeShLiquide = model.CodeShLiquide,
            CodeUniteQuantite = model.CodeUniteQuantite,
            ContenuEvaluationValeur = model.ContenuEvaluationValeur,
            CreatedAt = model.CreatedAt,
            DateDemande = model.DateDemande,
            DateEvaluationValeur = model.DateEvaluationValeur,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            DateValidation = model.DateValidation,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            MontantDeclareFacture = model.MontantDeclareFacture,
            MontantDeclareNcyFacture = model.MontantDeclareNcyFacture,
            MontantNcyLiquideFacture = model.MontantNcyLiquideFacture,
            MontantUsdLiquideFacture = model.MontantUsdLiquideFacture,
            NomArticle = model.NomArticle,
            NomComposant = model.NomComposant,
            NomEntrepriseExportateur = model.NomEntrepriseExportateur,
            NomEntrepriseImportateur = model.NomEntrepriseImportateur,
            NomMarque = model.NomMarque,
            NomModeleSpecification = model.NomModeleSpecification,
            NumeroArticle = model.NumeroArticle,
            NumeroDeclarationDetail = model.NumeroDeclarationDetail,
            NumeroIdentificationExportateur = model.NumeroIdentificationExportateur,
            NumeroIdentificationImportateur = model.NumeroIdentificationImportateur,
            NumeroModeleSpecification = model.NumeroModeleSpecification,
            PoidsNet = model.PoidsNet,
            PremierEnregistrantId = model.PremierEnregistrantId,
            PrixNcyUnitaireDeclare = model.PrixNcyUnitaireDeclare,
            PrixUnitaireNcyLiquide = model.PrixUnitaireNcyLiquide,
            PrixUnitaireUsdLiquide = model.PrixUnitaireUsdLiquide,
            PrixUsdUnitaireDeclare = model.PrixUsdUnitaireDeclare,
            Quantite = model.Quantite,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static PrixUnitaireDeclarationDetailDbModel ToModel(
        this PrixUnitaireDeclarationDetailUpdateInput updateDto,
        PrixUnitaireDeclarationDetailWhereUniqueInput uniqueId
    )
    {
        var prixUnitaireDeclarationDetail = new PrixUnitaireDeclarationDetailDbModel
        {
            Id = uniqueId.Id,
            CodeDevise = updateDto.CodeDevise,
            CodeMethodeEvaluationValeur = updateDto.CodeMethodeEvaluationValeur,
            CodePaysExpedition = updateDto.CodePaysExpedition,
            CodePaysOrigine = updateDto.CodePaysOrigine,
            CodeProduitNeufEtUsage = updateDto.CodeProduitNeufEtUsage,
            CodeShDeclare = updateDto.CodeShDeclare,
            CodeShLiquide = updateDto.CodeShLiquide,
            CodeUniteQuantite = updateDto.CodeUniteQuantite,
            ContenuEvaluationValeur = updateDto.ContenuEvaluationValeur,
            DateDemande = updateDto.DateDemande,
            DateEvaluationValeur = updateDto.DateEvaluationValeur,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            DateValidation = updateDto.DateValidation,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            MontantDeclareFacture = updateDto.MontantDeclareFacture,
            MontantDeclareNcyFacture = updateDto.MontantDeclareNcyFacture,
            MontantNcyLiquideFacture = updateDto.MontantNcyLiquideFacture,
            MontantUsdLiquideFacture = updateDto.MontantUsdLiquideFacture,
            NomArticle = updateDto.NomArticle,
            NomComposant = updateDto.NomComposant,
            NomEntrepriseExportateur = updateDto.NomEntrepriseExportateur,
            NomEntrepriseImportateur = updateDto.NomEntrepriseImportateur,
            NomMarque = updateDto.NomMarque,
            NomModeleSpecification = updateDto.NomModeleSpecification,
            NumeroArticle = updateDto.NumeroArticle,
            NumeroDeclarationDetail = updateDto.NumeroDeclarationDetail,
            NumeroIdentificationExportateur = updateDto.NumeroIdentificationExportateur,
            NumeroIdentificationImportateur = updateDto.NumeroIdentificationImportateur,
            NumeroModeleSpecification = updateDto.NumeroModeleSpecification,
            PoidsNet = updateDto.PoidsNet,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            PrixNcyUnitaireDeclare = updateDto.PrixNcyUnitaireDeclare,
            PrixUnitaireNcyLiquide = updateDto.PrixUnitaireNcyLiquide,
            PrixUnitaireUsdLiquide = updateDto.PrixUnitaireUsdLiquide,
            PrixUsdUnitaireDeclare = updateDto.PrixUsdUnitaireDeclare,
            Quantite = updateDto.Quantite,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            prixUnitaireDeclarationDetail.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            prixUnitaireDeclarationDetail.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return prixUnitaireDeclarationDetail;
    }
}
