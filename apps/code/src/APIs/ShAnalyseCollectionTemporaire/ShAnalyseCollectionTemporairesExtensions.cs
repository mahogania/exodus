using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ShAnalyseCollectionTemporairesExtensions
{
    public static ShAnalyseCollectionTemporaire ToDto(
        this ShAnalyseCollectionTemporaireDbModel model
    )
    {
        return new ShAnalyseCollectionTemporaire
        {
            ClassementGroupesPrixNcyUnitaires = model.ClassementGroupesPrixNcyUnitaires,
            ClassementGroupesPrixUsdUnitaires = model.ClassementGroupesPrixUsdUnitaires,
            ClassementPrixNcyUnitaires = model.ClassementPrixNcyUnitaires,
            ClassementPrixUsdUnitaires = model.ClassementPrixUsdUnitaires,
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
            PoidsParUnite = model.PoidsParUnite,
            PremierEnregistrantId = model.PremierEnregistrantId,
            PrixNcyUnitaire = model.PrixNcyUnitaire,
            PrixUsdUnitaire = model.PrixUsdUnitaire,
            Quantite = model.Quantite,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ShAnalyseCollectionTemporaireDbModel ToModel(
        this ShAnalyseCollectionTemporaireUpdateInput updateDto,
        ShAnalyseCollectionTemporaireWhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollectionTemporaire = new ShAnalyseCollectionTemporaireDbModel
        {
            Id = uniqueId.Id,
            ClassementGroupesPrixNcyUnitaires = updateDto.ClassementGroupesPrixNcyUnitaires,
            ClassementGroupesPrixUsdUnitaires = updateDto.ClassementGroupesPrixUsdUnitaires,
            ClassementPrixNcyUnitaires = updateDto.ClassementPrixNcyUnitaires,
            ClassementPrixUsdUnitaires = updateDto.ClassementPrixUsdUnitaires,
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
            PoidsParUnite = updateDto.PoidsParUnite,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            PrixNcyUnitaire = updateDto.PrixNcyUnitaire,
            PrixUsdUnitaire = updateDto.PrixUsdUnitaire,
            Quantite = updateDto.Quantite,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            shAnalyseCollectionTemporaire.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            shAnalyseCollectionTemporaire.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return shAnalyseCollectionTemporaire;
    }
}
