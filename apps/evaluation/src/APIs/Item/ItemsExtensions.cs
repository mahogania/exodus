using Evaluation.APIs.Dtos;
using Evaluation.Infrastructure.Models;

namespace Evaluation.APIs.Extensions;

public static class ItemsExtensions
{
    public static Item ToDto(this ItemDbModel model)
    {
        return new Item
        {
            CodeDeDeviseDDuitDeLArticle = model.CodeDeDeviseDDuitDeLArticle,
            CodeDeDeviseDeLAssuranceDeLArticle = model.CodeDeDeviseDeLAssuranceDeLArticle,
            CodeDeDeviseDeLaFactureDeLArticle = model.CodeDeDeviseDeLaFactureDeLArticle,
            CodeDeDeviseDeLaValeurMercurialeDeLArticle =
                model.CodeDeDeviseDeLaValeurMercurialeDeLArticle,
            CodeDeDeviseDesAutresFraisDeLArticle = model.CodeDeDeviseDesAutresFraisDeLArticle,
            CodeDeDeviseDuFretDeLArticle = model.CodeDeDeviseDuFretDeLArticle,
            CodeDeTypeDeLaValeurMercurialeDeLArticle =
                model.CodeDeTypeDeLaValeurMercurialeDeLArticle,
            CreatedAt = model.CreatedAt,
            DateEtHeureDeModificationFinale = model.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = model.DateEtHeureDePremierEnregistrement,
            FrQuenceDeRectification = model.FrQuenceDeRectification,
            Id = model.Id,
            IdDuModificateurFinal = model.IdDuModificateurFinal,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            MontantDDuitDeLArticle = model.MontantDDuitDeLArticle,
            MontantDeLAssuranceDeLArticle = model.MontantDeLAssuranceDeLArticle,
            MontantDeLaFactureDeLArticle = model.MontantDeLaFactureDeLArticle,
            MontantDesAutresFraisDeLArticle = model.MontantDesAutresFraisDeLArticle,
            MontantDuFretDeLArticle = model.MontantDuFretDeLArticle,
            MontantNcyDDuitDeLArticle = model.MontantNcyDDuitDeLArticle,
            MontantNcyDeLAssuranceDeLArticle = model.MontantNcyDeLAssuranceDeLArticle,
            MontantNcyDeLValuationDeValeurDeLArticle =
                model.MontantNcyDeLValuationDeValeurDeLArticle,
            MontantNcyDeLaFactureDeLArticle = model.MontantNcyDeLaFactureDeLArticle,
            MontantNcyDeLaValeurBoursiReDeLArticle = model.MontantNcyDeLaValeurBoursiReDeLArticle,
            MontantNcyDesAutresFraisDeLArticle = model.MontantNcyDesAutresFraisDeLArticle,
            MontantNcyDuFretDeLArticle = model.MontantNcyDuFretDeLArticle,
            MontantNycDeLaBaseTaxableDeLArticle = model.MontantNycDeLaBaseTaxableDeLArticle,
            MontantUnitaireDeLaValeurBoursiReDeLArticle =
                model.MontantUnitaireDeLaValeurBoursiReDeLArticle,
            MontantUsdDeLValuationDeValeurDeLArticle =
                model.MontantUsdDeLValuationDeValeurDeLArticle,
            MontantUsdDeLaBaseTaxableDeLArticle = model.MontantUsdDeLaBaseTaxableDeLArticle,
            MontantUsdDeLaFactureDeLArticle = model.MontantUsdDeLaFactureDeLArticle,
            MontantUsdDeLaValeurBoursiReDeLArticle = model.MontantUsdDeLaValeurBoursiReDeLArticle,
            NDArticle = model.NDArticle,
            NDeRfRence = model.NDeRfRence,
            SuppressionOn = model.SuppressionOn,
            TauxDeChangeDeLAssuranceDeLArticle = model.TauxDeChangeDeLAssuranceDeLArticle,
            TauxDeChangeDeLaDDuctionDeLArticle = model.TauxDeChangeDeLaDDuctionDeLArticle,
            TauxDeChangeDeLaFactureDeLArticle = model.TauxDeChangeDeLaFactureDeLArticle,
            TauxDeChangeDesAutresFraisDeLArticle = model.TauxDeChangeDesAutresFraisDeLArticle,
            TauxDeChangeDuFretDeLArticle = model.TauxDeChangeDuFretDeLArticle,
            UpdatedAt = model.UpdatedAt,
            ValeurBasiqueDeLaValeurBoursiReDeLArticle =
                model.ValeurBasiqueDeLaValeurBoursiReDeLArticle,
        };
    }

    public static ItemDbModel ToModel(this ItemUpdateInput updateDto, ItemWhereUniqueInput uniqueId)
    {
        var item = new ItemDbModel
        {
            Id = uniqueId.Id,
            CodeDeDeviseDDuitDeLArticle = updateDto.CodeDeDeviseDDuitDeLArticle,
            CodeDeDeviseDeLAssuranceDeLArticle = updateDto.CodeDeDeviseDeLAssuranceDeLArticle,
            CodeDeDeviseDeLaFactureDeLArticle = updateDto.CodeDeDeviseDeLaFactureDeLArticle,
            CodeDeDeviseDeLaValeurMercurialeDeLArticle =
                updateDto.CodeDeDeviseDeLaValeurMercurialeDeLArticle,
            CodeDeDeviseDesAutresFraisDeLArticle = updateDto.CodeDeDeviseDesAutresFraisDeLArticle,
            CodeDeDeviseDuFretDeLArticle = updateDto.CodeDeDeviseDuFretDeLArticle,
            CodeDeTypeDeLaValeurMercurialeDeLArticle =
                updateDto.CodeDeTypeDeLaValeurMercurialeDeLArticle,
            DateEtHeureDeModificationFinale = updateDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = updateDto.DateEtHeureDePremierEnregistrement,
            FrQuenceDeRectification = updateDto.FrQuenceDeRectification,
            IdDuModificateurFinal = updateDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            MontantDDuitDeLArticle = updateDto.MontantDDuitDeLArticle,
            MontantDeLAssuranceDeLArticle = updateDto.MontantDeLAssuranceDeLArticle,
            MontantDeLaFactureDeLArticle = updateDto.MontantDeLaFactureDeLArticle,
            MontantDesAutresFraisDeLArticle = updateDto.MontantDesAutresFraisDeLArticle,
            MontantDuFretDeLArticle = updateDto.MontantDuFretDeLArticle,
            MontantNcyDDuitDeLArticle = updateDto.MontantNcyDDuitDeLArticle,
            MontantNcyDeLAssuranceDeLArticle = updateDto.MontantNcyDeLAssuranceDeLArticle,
            MontantNcyDeLValuationDeValeurDeLArticle =
                updateDto.MontantNcyDeLValuationDeValeurDeLArticle,
            MontantNcyDeLaFactureDeLArticle = updateDto.MontantNcyDeLaFactureDeLArticle,
            MontantNcyDeLaValeurBoursiReDeLArticle =
                updateDto.MontantNcyDeLaValeurBoursiReDeLArticle,
            MontantNcyDesAutresFraisDeLArticle = updateDto.MontantNcyDesAutresFraisDeLArticle,
            MontantNcyDuFretDeLArticle = updateDto.MontantNcyDuFretDeLArticle,
            MontantNycDeLaBaseTaxableDeLArticle = updateDto.MontantNycDeLaBaseTaxableDeLArticle,
            MontantUnitaireDeLaValeurBoursiReDeLArticle =
                updateDto.MontantUnitaireDeLaValeurBoursiReDeLArticle,
            MontantUsdDeLValuationDeValeurDeLArticle =
                updateDto.MontantUsdDeLValuationDeValeurDeLArticle,
            MontantUsdDeLaBaseTaxableDeLArticle = updateDto.MontantUsdDeLaBaseTaxableDeLArticle,
            MontantUsdDeLaFactureDeLArticle = updateDto.MontantUsdDeLaFactureDeLArticle,
            MontantUsdDeLaValeurBoursiReDeLArticle =
                updateDto.MontantUsdDeLaValeurBoursiReDeLArticle,
            NDArticle = updateDto.NDArticle,
            NDeRfRence = updateDto.NDeRfRence,
            SuppressionOn = updateDto.SuppressionOn,
            TauxDeChangeDeLAssuranceDeLArticle = updateDto.TauxDeChangeDeLAssuranceDeLArticle,
            TauxDeChangeDeLaDDuctionDeLArticle = updateDto.TauxDeChangeDeLaDDuctionDeLArticle,
            TauxDeChangeDeLaFactureDeLArticle = updateDto.TauxDeChangeDeLaFactureDeLArticle,
            TauxDeChangeDesAutresFraisDeLArticle = updateDto.TauxDeChangeDesAutresFraisDeLArticle,
            TauxDeChangeDuFretDeLArticle = updateDto.TauxDeChangeDuFretDeLArticle,
            ValeurBasiqueDeLaValeurBoursiReDeLArticle =
                updateDto.ValeurBasiqueDeLaValeurBoursiReDeLArticle
        };

        if (updateDto.CreatedAt != null)
        {
            item.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            item.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return item;
    }
}
