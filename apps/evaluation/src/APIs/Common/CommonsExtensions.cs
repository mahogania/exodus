using Evaluation.APIs.Dtos;
using Evaluation.Infrastructure.Models;

namespace Evaluation.APIs.Extensions;

public static class CommonsExtensions
{
    public static Common ToDto(this CommonDbModel model)
    {
        return new Common
        {
            CodeDeDeviseDAssurance = model.CodeDeDeviseDAssurance,
            CodeDeDeviseDeLaDDuction = model.CodeDeDeviseDeLaDDuction,
            CodeDeDeviseDeLaFacture = model.CodeDeDeviseDeLaFacture,
            CodeDeDeviseDesAutresCoTs = model.CodeDeDeviseDesAutresCoTs,
            CodeDeDeviseDuFret = model.CodeDeDeviseDuFret,
            CreatedAt = model.CreatedAt,
            DateEtHeureDeModificationFinale = model.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = model.DateEtHeureDePremierEnregistrement,
            FrQuenceDeRectification = model.FrQuenceDeRectification,
            Id = model.Id,
            IdDuModificateurFinal = model.IdDuModificateurFinal,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            MontantDAssurance = model.MontantDAssurance,
            MontantDDuit = model.MontantDDuit,
            MontantDeFacture = model.MontantDeFacture,
            MontantDesAutresCoTs = model.MontantDesAutresCoTs,
            MontantDesAutresCoTsDeNcy = model.MontantDesAutresCoTsDeNcy,
            MontantDuFret = model.MontantDuFret,
            MontantNcyDDuit = model.MontantNcyDDuit,
            MontantNcyDeFacture = model.MontantNcyDeFacture,
            MontantNcyDuFret = model.MontantNcyDuFret,
            MontantNcyTotalDeLValuationDeValeur = model.MontantNcyTotalDeLValuationDeValeur,
            MontantNcyTotalDeLaBaseTaxable = model.MontantNcyTotalDeLaBaseTaxable,
            MontantNycDeLAssurance = model.MontantNycDeLAssurance,
            MontantUsdDeFacture = model.MontantUsdDeFacture,
            MontantUsdTotalDeLValuationDeValeur = model.MontantUsdTotalDeLValuationDeValeur,
            MontantUsdTotalDeLaBaseTaxable = model.MontantUsdTotalDeLaBaseTaxable,
            NDeRfRence = model.NDeRfRence,
            SuppressionOn = model.SuppressionOn,
            TauxDeChangeDAssurance = model.TauxDeChangeDAssurance,
            TauxDeChangeDeLaDDuction = model.TauxDeChangeDeLaDDuction,
            TauxDeChangeDeLaFacture = model.TauxDeChangeDeLaFacture,
            TauxDeChangeDesAutresCoTs = model.TauxDeChangeDesAutresCoTs,
            TauxDeChangeDuFret = model.TauxDeChangeDuFret,
            TauxDeRemise = model.TauxDeRemise,
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
            CodeDeDeviseDAssurance = updateDto.CodeDeDeviseDAssurance,
            CodeDeDeviseDeLaDDuction = updateDto.CodeDeDeviseDeLaDDuction,
            CodeDeDeviseDeLaFacture = updateDto.CodeDeDeviseDeLaFacture,
            CodeDeDeviseDesAutresCoTs = updateDto.CodeDeDeviseDesAutresCoTs,
            CodeDeDeviseDuFret = updateDto.CodeDeDeviseDuFret,
            DateEtHeureDeModificationFinale = updateDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = updateDto.DateEtHeureDePremierEnregistrement,
            FrQuenceDeRectification = updateDto.FrQuenceDeRectification,
            IdDuModificateurFinal = updateDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            MontantDAssurance = updateDto.MontantDAssurance,
            MontantDDuit = updateDto.MontantDDuit,
            MontantDeFacture = updateDto.MontantDeFacture,
            MontantDesAutresCoTs = updateDto.MontantDesAutresCoTs,
            MontantDesAutresCoTsDeNcy = updateDto.MontantDesAutresCoTsDeNcy,
            MontantDuFret = updateDto.MontantDuFret,
            MontantNcyDDuit = updateDto.MontantNcyDDuit,
            MontantNcyDeFacture = updateDto.MontantNcyDeFacture,
            MontantNcyDuFret = updateDto.MontantNcyDuFret,
            MontantNcyTotalDeLValuationDeValeur = updateDto.MontantNcyTotalDeLValuationDeValeur,
            MontantNcyTotalDeLaBaseTaxable = updateDto.MontantNcyTotalDeLaBaseTaxable,
            MontantNycDeLAssurance = updateDto.MontantNycDeLAssurance,
            MontantUsdDeFacture = updateDto.MontantUsdDeFacture,
            MontantUsdTotalDeLValuationDeValeur = updateDto.MontantUsdTotalDeLValuationDeValeur,
            MontantUsdTotalDeLaBaseTaxable = updateDto.MontantUsdTotalDeLaBaseTaxable,
            NDeRfRence = updateDto.NDeRfRence,
            SuppressionOn = updateDto.SuppressionOn,
            TauxDeChangeDAssurance = updateDto.TauxDeChangeDAssurance,
            TauxDeChangeDeLaDDuction = updateDto.TauxDeChangeDeLaDDuction,
            TauxDeChangeDeLaFacture = updateDto.TauxDeChangeDeLaFacture,
            TauxDeChangeDesAutresCoTs = updateDto.TauxDeChangeDesAutresCoTs,
            TauxDeChangeDuFret = updateDto.TauxDeChangeDuFret,
            TauxDeRemise = updateDto.TauxDeRemise
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
