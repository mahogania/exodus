using Evaluation.APIs.Dtos;
using Evaluation.Infrastructure.Models;

namespace Evaluation.APIs.Extensions;

public static class DetailsExtensions
{
    public static Detail ToDto(this DetailDbModel model)
    {
        return new Detail
        {
            AdreseDeLExpDiteur = model.AdreseDeLExpDiteur,
            AdresseDeDestinataire = model.AdresseDeDestinataire,
            CodeDIdentificationDeDestinataire = model.CodeDIdentificationDeDestinataire,
            CodeDeDDouanement = model.CodeDeDDouanement,
            CodeDeLOpRateurExpress = model.CodeDeLOpRateurExpress,
            CodeDePaysDExpDition = model.CodeDePaysDExpDition,
            CodeDeStatutDeTraitement = model.CodeDeStatutDeTraitement,
            CodeDeTransporteur = model.CodeDeTransporteur,
            CodeDeTypeDeTraitementDeDDouanementExpress =
                model.CodeDeTypeDeTraitementDeDDouanementExpress,
            CodeDeTypeDesFins = model.CodeDeTypeDesFins,
            CodePostalDeDestinataire = model.CodePostalDeDestinataire,
            CodeSh = model.CodeSh,
            ContenuDeCodeBarre = model.ContenuDeCodeBarre,
            CreatedAt = model.CreatedAt,
            DDouanementOrdinaireOn = model.DDouanementOrdinaireOn,
            DDouanementSimplifiOn = model.DDouanementSimplifiOn,
            DNominationCommerciale = model.DNominationCommerciale,
            DateEtHeureDeModificationFinale = model.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = model.DateEtHeureDePremierEnregistrement,
            DateEtHeureDeTransmissionDeCodeBarre = model.DateEtHeureDeTransmissionDeCodeBarre,
            Id = model.Id,
            IdDuModificateurFinal = model.IdDuModificateurFinal,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            MontantDeLaTaxeDouaniReSimple = model.MontantDeLaTaxeDouaniReSimple,
            NDeCertificationDeLEntrepriseDeCommercialLectronique =
                model.NDeCertificationDeLEntrepriseDeCommercialLectronique,
            NDeDemandeDeDDouanementExpress = model.NDeDemandeDeDDouanementExpress,
            NDeHouseBl = model.NDeHouseBl,
            NDeMasterBl = model.NDeMasterBl,
            NDeSQuence = model.NDeSQuence,
            NDeTlPhoneDeDestinataire = model.NDeTlPhoneDeDestinataire,
            NDeTlPhoneDeLExpDiteur = model.NDeTlPhoneDeLExpDiteur,
            NomDeDestinataire = model.NomDeDestinataire,
            NomDeLExpDiteur = model.NomDeLExpDiteur,
            NoteDeDouane = model.NoteDeDouane,
            Poids = model.Poids,
            Quantit = model.Quantit,
            QuantitDuColis = model.QuantitDuColis,
            SiteInternetDeECommercial = model.SiteInternetDeECommercial,
            Standards = model.Standards,
            SuppressionOn = model.SuppressionOn,
            TypeDOpRation = model.TypeDOpRation,
            UpdatedAt = model.UpdatedAt,
            ValeurDeMarchandise = model.ValeurDeMarchandise,
        };
    }

    public static DetailDbModel ToModel(
        this DetailUpdateInput updateDto,
        DetailWhereUniqueInput uniqueId
    )
    {
        var detail = new DetailDbModel
        {
            Id = uniqueId.Id,
            AdreseDeLExpDiteur = updateDto.AdreseDeLExpDiteur,
            AdresseDeDestinataire = updateDto.AdresseDeDestinataire,
            CodeDIdentificationDeDestinataire = updateDto.CodeDIdentificationDeDestinataire,
            CodeDeDDouanement = updateDto.CodeDeDDouanement,
            CodeDeLOpRateurExpress = updateDto.CodeDeLOpRateurExpress,
            CodeDePaysDExpDition = updateDto.CodeDePaysDExpDition,
            CodeDeStatutDeTraitement = updateDto.CodeDeStatutDeTraitement,
            CodeDeTransporteur = updateDto.CodeDeTransporteur,
            CodeDeTypeDeTraitementDeDDouanementExpress =
                updateDto.CodeDeTypeDeTraitementDeDDouanementExpress,
            CodeDeTypeDesFins = updateDto.CodeDeTypeDesFins,
            CodePostalDeDestinataire = updateDto.CodePostalDeDestinataire,
            CodeSh = updateDto.CodeSh,
            ContenuDeCodeBarre = updateDto.ContenuDeCodeBarre,
            DDouanementOrdinaireOn = updateDto.DDouanementOrdinaireOn,
            DDouanementSimplifiOn = updateDto.DDouanementSimplifiOn,
            DNominationCommerciale = updateDto.DNominationCommerciale,
            DateEtHeureDeModificationFinale = updateDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = updateDto.DateEtHeureDePremierEnregistrement,
            DateEtHeureDeTransmissionDeCodeBarre = updateDto.DateEtHeureDeTransmissionDeCodeBarre,
            IdDuModificateurFinal = updateDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            MontantDeLaTaxeDouaniReSimple = updateDto.MontantDeLaTaxeDouaniReSimple,
            NDeCertificationDeLEntrepriseDeCommercialLectronique =
                updateDto.NDeCertificationDeLEntrepriseDeCommercialLectronique,
            NDeDemandeDeDDouanementExpress = updateDto.NDeDemandeDeDDouanementExpress,
            NDeHouseBl = updateDto.NDeHouseBl,
            NDeMasterBl = updateDto.NDeMasterBl,
            NDeSQuence = updateDto.NDeSQuence,
            NDeTlPhoneDeDestinataire = updateDto.NDeTlPhoneDeDestinataire,
            NDeTlPhoneDeLExpDiteur = updateDto.NDeTlPhoneDeLExpDiteur,
            NomDeDestinataire = updateDto.NomDeDestinataire,
            NomDeLExpDiteur = updateDto.NomDeLExpDiteur,
            NoteDeDouane = updateDto.NoteDeDouane,
            Poids = updateDto.Poids,
            Quantit = updateDto.Quantit,
            QuantitDuColis = updateDto.QuantitDuColis,
            SiteInternetDeECommercial = updateDto.SiteInternetDeECommercial,
            Standards = updateDto.Standards,
            SuppressionOn = updateDto.SuppressionOn,
            TypeDOpRation = updateDto.TypeDOpRation,
            ValeurDeMarchandise = updateDto.ValeurDeMarchandise
        };

        if (updateDto.CreatedAt != null)
        {
            detail.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            detail.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return detail;
    }
}
