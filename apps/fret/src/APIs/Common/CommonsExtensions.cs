using Fret.APIs.Dtos;
using Fret.Infrastructure.Models;

namespace Fret.APIs.Extensions;

public static class CommonsExtensions
{
    public static Common ToDto(this CommonDbModel model)
    {
        return new Common
        {
            AutoLiquidationOn = model.AutoLiquidationOn,
            CargaisonConteneurisEOn = model.CargaisonConteneurisEOn,
            CodeDAgnceDeBanqueDePaiement = model.CodeDAgnceDeBanqueDePaiement,
            CodeDEntrepTDeLaMarchandiseSousDouane = model.CodeDEntrepTDeLaMarchandiseSousDouane,
            CodeDeBanqueDePaiement = model.CodeDeBanqueDePaiement,
            CodeDeBureauDeDClaration = model.CodeDeBureauDeDClaration,
            CodeDeConditionDeTransaction_1 = model.CodeDeConditionDeTransaction_1,
            CodeDeConditionDeTransaction_2 = model.CodeDeConditionDeTransaction_2,
            CodeDeFormulaireDeLaDClaration = model.CodeDeFormulaireDeLaDClaration,
            CodeDeLEntrepTPrCDentDeLaMarchandiseSousDouane =
                model.CodeDeLEntrepTPrCDentDeLaMarchandiseSousDouane,
            CodeDeLaConditionDeLivraison = model.CodeDeLaConditionDeLivraison,
            CodeDeLieuDeChargement = model.CodeDeLieuDeChargement,
            CodeDeLieuDeDChargement = model.CodeDeLieuDeDChargement,
            CodeDeLocalisationDeStockage = model.CodeDeLocalisationDeStockage,
            CodeDeModeDePaiement = model.CodeDeModeDePaiement,
            CodeDeMotifDeLaModification = model.CodeDeMotifDeLaModification,
            CodeDeNationalitDuMoyenDeTransport = model.CodeDeNationalitDuMoyenDeTransport,
            CodeDePaysDExpDition = model.CodeDePaysDExpDition,
            CodeDePaysDeTransaction = model.CodeDePaysDeTransaction,
            CodeDePaysDestinataire = model.CodeDePaysDestinataire,
            CodeDePaysExportateur = model.CodeDePaysExportateur,
            CodeDePlanDeDDouanement = model.CodeDePlanDeDDouanement,
            CodeDeRGionDestinataire = model.CodeDeRGionDestinataire,
            CodeDeService = model.CodeDeService,
            CodeDeStatutDeDomiciliation = model.CodeDeStatutDeDomiciliation,
            CodeDeTypeDeDClaration = model.CodeDeTypeDeDClaration,
            CodeDeTypeDeDDouanementPartiel = model.CodeDeTypeDeDDouanementPartiel,
            CodeDeTypeDeNdIdentificationDeLExportateur =
                model.CodeDeTypeDeNdIdentificationDeLExportateur,
            CodeDeTypeDuMoyenDeTransport = model.CodeDeTypeDuMoyenDeTransport,
            CodeDeTypeDuNdIdentificationDeLImportateur =
                model.CodeDeTypeDuNdIdentificationDeLImportateur,
            CodeDuBureauDEntrEEtDeSortie = model.CodeDuBureauDEntrEEtDeSortie,
            CodeDuDClarant = model.CodeDuDClarant,
            CodeDuLieuDeLivraison = model.CodeDuLieuDeLivraison,
            CodeEpc = model.CodeEpc,
            CreatedAt = model.CreatedAt,
            Crn = model.Crn,
            DClarationDeLaValeurSaisieOn = model.DClarationDeLaValeurSaisieOn,
            DateDArrivE = model.DateDArrivE,
            DateDMissionDeLaFacture = model.DateDMissionDeLaFacture,
            DateDeConnaissement = model.DateDeConnaissement,
            DateDeDChargement = model.DateDeDChargement,
            DateDeDemande = model.DateDeDemande,
            DateDeDomiciliation = model.DateDeDomiciliation,
            DateEtHeureDeModificationFinale = model.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = model.DateEtHeureDePremierEnregistrement,
            DateInitialeDeLaDClaration = model.DateInitialeDeLaDClaration,
            EnlVementEnVHiculeOn = model.EnlVementEnVHiculeOn,
            FinalOn = model.FinalOn,
            FrQuenceDeRectification = model.FrQuenceDeRectification,
            Id = model.Id,
            IdDuModificateurFinal = model.IdDuModificateurFinal,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            ModeFinancement = model.ModeFinancement,
            MotifDeRectification = model.MotifDeRectification,
            NDIdentificationDeLExportateur = model.NDIdentificationDeLExportateur,
            NDIdentificationDeLImportateur = model.NDIdentificationDeLImportateur,
            NDIdentificationDeRedevable = model.NDIdentificationDeRedevable,
            NDIdentificationDuMoyenDeTransport = model.NDIdentificationDuMoyenDeTransport,
            NDeBl = model.NDeBl,
            NDeCompteDePaiement = model.NDeCompteDePaiement,
            NDeDemandeDeRGime = model.NDeDemandeDeRGime,
            NDeFacture = model.NDeFacture,
            NDeRfRence = model.NDeRfRence,
            NomDuNavire = model.NomDuNavire,
            NombreDArticles = model.NombreDArticles,
            NombreDeConteneurs = model.NombreDeConteneurs,
            NombreTotalDeColis = model.NombreTotalDeColis,
            NumRoDeRfRenceDeVoyageur = model.NumRoDeRfRenceDeVoyageur,
            NumRoDeRegistreDeCommerceDeLExportateur = model.NumRoDeRegistreDeCommerceDeLExportateur,
            NumRoDeRegistreDeCommerceDeLImportateur = model.NumRoDeRegistreDeCommerceDeLImportateur,
            NumRoDeRegistreDeCommerceDuRedevable = model.NumRoDeRegistreDeCommerceDuRedevable,
            NumeroDeLaDClarationEnDTail = model.NumeroDeLaDClarationEnDTail,
            PRiodeDChAnceDeLApurementDeLaGestionEtSuivi =
                model.PRiodeDChAnceDeLApurementDeLaGestionEtSuivi,
            PoidsBrutTotal = model.PoidsBrutTotal,
            PoidsNetTotal = model.PoidsNetTotal,
            SuppressionOn = model.SuppressionOn,
            TempsUtilisationDuSystMeEnSeconde = model.TempsUtilisationDuSystMeEnSeconde,
            TexteDeTraitementDeVoyageur = model.TexteDeTraitementDeVoyageur,
            TexteLibreRServAuDClarant = model.TexteLibreRServAuDClarant,
            TypeDOpRation = model.TypeDOpRation,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CommonDbModel ToModel(
        this CommonUpdateInput updateDto,
        CommonWhereUniqueInput uniqueId
    )
    {
        var common = new CommonDbModel
        {
            Id = uniqueId.Id,
            AutoLiquidationOn = updateDto.AutoLiquidationOn,
            CargaisonConteneurisEOn = updateDto.CargaisonConteneurisEOn,
            CodeDAgnceDeBanqueDePaiement = updateDto.CodeDAgnceDeBanqueDePaiement,
            CodeDEntrepTDeLaMarchandiseSousDouane = updateDto.CodeDEntrepTDeLaMarchandiseSousDouane,
            CodeDeBanqueDePaiement = updateDto.CodeDeBanqueDePaiement,
            CodeDeBureauDeDClaration = updateDto.CodeDeBureauDeDClaration,
            CodeDeConditionDeTransaction_1 = updateDto.CodeDeConditionDeTransaction_1,
            CodeDeConditionDeTransaction_2 = updateDto.CodeDeConditionDeTransaction_2,
            CodeDeFormulaireDeLaDClaration = updateDto.CodeDeFormulaireDeLaDClaration,
            CodeDeLEntrepTPrCDentDeLaMarchandiseSousDouane =
                updateDto.CodeDeLEntrepTPrCDentDeLaMarchandiseSousDouane,
            CodeDeLaConditionDeLivraison = updateDto.CodeDeLaConditionDeLivraison,
            CodeDeLieuDeChargement = updateDto.CodeDeLieuDeChargement,
            CodeDeLieuDeDChargement = updateDto.CodeDeLieuDeDChargement,
            CodeDeLocalisationDeStockage = updateDto.CodeDeLocalisationDeStockage,
            CodeDeModeDePaiement = updateDto.CodeDeModeDePaiement,
            CodeDeMotifDeLaModification = updateDto.CodeDeMotifDeLaModification,
            CodeDeNationalitDuMoyenDeTransport = updateDto.CodeDeNationalitDuMoyenDeTransport,
            CodeDePaysDExpDition = updateDto.CodeDePaysDExpDition,
            CodeDePaysDeTransaction = updateDto.CodeDePaysDeTransaction,
            CodeDePaysDestinataire = updateDto.CodeDePaysDestinataire,
            CodeDePaysExportateur = updateDto.CodeDePaysExportateur,
            CodeDePlanDeDDouanement = updateDto.CodeDePlanDeDDouanement,
            CodeDeRGionDestinataire = updateDto.CodeDeRGionDestinataire,
            CodeDeService = updateDto.CodeDeService,
            CodeDeStatutDeDomiciliation = updateDto.CodeDeStatutDeDomiciliation,
            CodeDeTypeDeDClaration = updateDto.CodeDeTypeDeDClaration,
            CodeDeTypeDeDDouanementPartiel = updateDto.CodeDeTypeDeDDouanementPartiel,
            CodeDeTypeDeNdIdentificationDeLExportateur =
                updateDto.CodeDeTypeDeNdIdentificationDeLExportateur,
            CodeDeTypeDuMoyenDeTransport = updateDto.CodeDeTypeDuMoyenDeTransport,
            CodeDeTypeDuNdIdentificationDeLImportateur =
                updateDto.CodeDeTypeDuNdIdentificationDeLImportateur,
            CodeDuBureauDEntrEEtDeSortie = updateDto.CodeDuBureauDEntrEEtDeSortie,
            CodeDuDClarant = updateDto.CodeDuDClarant,
            CodeDuLieuDeLivraison = updateDto.CodeDuLieuDeLivraison,
            CodeEpc = updateDto.CodeEpc,
            Crn = updateDto.Crn,
            DClarationDeLaValeurSaisieOn = updateDto.DClarationDeLaValeurSaisieOn,
            DateDArrivE = updateDto.DateDArrivE,
            DateDMissionDeLaFacture = updateDto.DateDMissionDeLaFacture,
            DateDeConnaissement = updateDto.DateDeConnaissement,
            DateDeDChargement = updateDto.DateDeDChargement,
            DateDeDemande = updateDto.DateDeDemande,
            DateDeDomiciliation = updateDto.DateDeDomiciliation,
            DateEtHeureDeModificationFinale = updateDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = updateDto.DateEtHeureDePremierEnregistrement,
            DateInitialeDeLaDClaration = updateDto.DateInitialeDeLaDClaration,
            EnlVementEnVHiculeOn = updateDto.EnlVementEnVHiculeOn,
            FinalOn = updateDto.FinalOn,
            FrQuenceDeRectification = updateDto.FrQuenceDeRectification,
            IdDuModificateurFinal = updateDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            ModeFinancement = updateDto.ModeFinancement,
            MotifDeRectification = updateDto.MotifDeRectification,
            NDIdentificationDeLExportateur = updateDto.NDIdentificationDeLExportateur,
            NDIdentificationDeLImportateur = updateDto.NDIdentificationDeLImportateur,
            NDIdentificationDeRedevable = updateDto.NDIdentificationDeRedevable,
            NDIdentificationDuMoyenDeTransport = updateDto.NDIdentificationDuMoyenDeTransport,
            NDeBl = updateDto.NDeBl,
            NDeCompteDePaiement = updateDto.NDeCompteDePaiement,
            NDeDemandeDeRGime = updateDto.NDeDemandeDeRGime,
            NDeFacture = updateDto.NDeFacture,
            NDeRfRence = updateDto.NDeRfRence,
            NomDuNavire = updateDto.NomDuNavire,
            NombreDArticles = updateDto.NombreDArticles,
            NombreDeConteneurs = updateDto.NombreDeConteneurs,
            NombreTotalDeColis = updateDto.NombreTotalDeColis,
            NumRoDeRfRenceDeVoyageur = updateDto.NumRoDeRfRenceDeVoyageur,
            NumRoDeRegistreDeCommerceDeLExportateur =
                updateDto.NumRoDeRegistreDeCommerceDeLExportateur,
            NumRoDeRegistreDeCommerceDeLImportateur =
                updateDto.NumRoDeRegistreDeCommerceDeLImportateur,
            NumRoDeRegistreDeCommerceDuRedevable = updateDto.NumRoDeRegistreDeCommerceDuRedevable,
            NumeroDeLaDClarationEnDTail = updateDto.NumeroDeLaDClarationEnDTail,
            PRiodeDChAnceDeLApurementDeLaGestionEtSuivi =
                updateDto.PRiodeDChAnceDeLApurementDeLaGestionEtSuivi,
            PoidsBrutTotal = updateDto.PoidsBrutTotal,
            PoidsNetTotal = updateDto.PoidsNetTotal,
            SuppressionOn = updateDto.SuppressionOn,
            TempsUtilisationDuSystMeEnSeconde = updateDto.TempsUtilisationDuSystMeEnSeconde,
            TexteDeTraitementDeVoyageur = updateDto.TexteDeTraitementDeVoyageur,
            TexteLibreRServAuDClarant = updateDto.TexteLibreRServAuDClarant,
            TypeDOpRation = updateDto.TypeDOpRation
        };

        if (updateDto.CreatedAt != null)
        {
            common.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            common.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return common;
    }
}
