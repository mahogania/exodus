using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ValeurBoursieresExtensions
{
    public static ValeurBoursiere ToDto(this ValeurBoursiereDbModel model)
    {
        return new ValeurBoursiere
        {
            CodeDevisePoidsBrutExporte = model.CodeDevisePoidsBrutExporte,
            CodeDevisePoidsBrutImporte = model.CodeDevisePoidsBrutImporte,
            CodeDevisePoidsNetExporte = model.CodeDevisePoidsNetExporte,
            CodeDevisePoidsNetImporte = model.CodeDevisePoidsNetImporte,
            CodeDeviseUnite1QuantiteExportee = model.CodeDeviseUnite1QuantiteExportee,
            CodeDeviseUnite1QuantiteImportee = model.CodeDeviseUnite1QuantiteImportee,
            CodeDeviseUnite2QuantiteExportee = model.CodeDeviseUnite2QuantiteExportee,
            CodeDeviseUnite2QuantiteImportee = model.CodeDeviseUnite2QuantiteImportee,
            CodeDeviseUnite3QuantiteExportee = model.CodeDeviseUnite3QuantiteExportee,
            CodeDeviseUnite3QuantiteImportee = model.CodeDeviseUnite3QuantiteImportee,
            CodeValeurBoursiere = model.CodeValeurBoursiere,
            CreatedAt = model.CreatedAt,
            DateDebutApplicationValeurBoursiere = model.DateDebutApplicationValeurBoursiere,
            DateFinApplicationValeurBoursiere = model.DateFinApplicationValeurBoursiere,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            NomValeurBoursiere = model.NomValeurBoursiere,
            PremierEnregistrantId = model.PremierEnregistrantId,
            PrixBaseTaxableModifieOn = model.PrixBaseTaxableModifieOn,
            PrixLePlusHauxOn = model.PrixLePlusHauxOn,
            PrixUnitairePoidsBrutExporte = model.PrixUnitairePoidsBrutExporte,
            PrixUnitairePoidsBrutImporte = model.PrixUnitairePoidsBrutImporte,
            PrixUnitairePoidsNetExporte = model.PrixUnitairePoidsNetExporte,
            PrixUnitairePoidsNetImporte = model.PrixUnitairePoidsNetImporte,
            PrixUnitaireUnite1QuantiteExportee = model.PrixUnitaireUnite1QuantiteExportee,
            PrixUnitaireUnite1QuantiteImportee = model.PrixUnitaireUnite1QuantiteImportee,
            PrixUnitaireUnite2QuantiteExportee = model.PrixUnitaireUnite2QuantiteExportee,
            PrixUnitaireUnite2QuantiteImportee = model.PrixUnitaireUnite2QuantiteImportee,
            PrixUnitaireUnite3QuantiteExportee = model.PrixUnitaireUnite3QuantiteExportee,
            PrixUnitaireUnite3QuantiteImportee = model.PrixUnitaireUnite3QuantiteImportee,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ValeurBoursiereDbModel ToModel(
        this ValeurBoursiereUpdateInput updateDto,
        ValeurBoursiereWhereUniqueInput uniqueId
    )
    {
        var valeurBoursiere = new ValeurBoursiereDbModel
        {
            Id = uniqueId.Id,
            CodeDevisePoidsBrutExporte = updateDto.CodeDevisePoidsBrutExporte,
            CodeDevisePoidsBrutImporte = updateDto.CodeDevisePoidsBrutImporte,
            CodeDevisePoidsNetExporte = updateDto.CodeDevisePoidsNetExporte,
            CodeDevisePoidsNetImporte = updateDto.CodeDevisePoidsNetImporte,
            CodeDeviseUnite1QuantiteExportee = updateDto.CodeDeviseUnite1QuantiteExportee,
            CodeDeviseUnite1QuantiteImportee = updateDto.CodeDeviseUnite1QuantiteImportee,
            CodeDeviseUnite2QuantiteExportee = updateDto.CodeDeviseUnite2QuantiteExportee,
            CodeDeviseUnite2QuantiteImportee = updateDto.CodeDeviseUnite2QuantiteImportee,
            CodeDeviseUnite3QuantiteExportee = updateDto.CodeDeviseUnite3QuantiteExportee,
            CodeDeviseUnite3QuantiteImportee = updateDto.CodeDeviseUnite3QuantiteImportee,
            CodeValeurBoursiere = updateDto.CodeValeurBoursiere,
            DateDebutApplicationValeurBoursiere = updateDto.DateDebutApplicationValeurBoursiere,
            DateFinApplicationValeurBoursiere = updateDto.DateFinApplicationValeurBoursiere,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            NomValeurBoursiere = updateDto.NomValeurBoursiere,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            PrixBaseTaxableModifieOn = updateDto.PrixBaseTaxableModifieOn,
            PrixLePlusHauxOn = updateDto.PrixLePlusHauxOn,
            PrixUnitairePoidsBrutExporte = updateDto.PrixUnitairePoidsBrutExporte,
            PrixUnitairePoidsBrutImporte = updateDto.PrixUnitairePoidsBrutImporte,
            PrixUnitairePoidsNetExporte = updateDto.PrixUnitairePoidsNetExporte,
            PrixUnitairePoidsNetImporte = updateDto.PrixUnitairePoidsNetImporte,
            PrixUnitaireUnite1QuantiteExportee = updateDto.PrixUnitaireUnite1QuantiteExportee,
            PrixUnitaireUnite1QuantiteImportee = updateDto.PrixUnitaireUnite1QuantiteImportee,
            PrixUnitaireUnite2QuantiteExportee = updateDto.PrixUnitaireUnite2QuantiteExportee,
            PrixUnitaireUnite2QuantiteImportee = updateDto.PrixUnitaireUnite2QuantiteImportee,
            PrixUnitaireUnite3QuantiteExportee = updateDto.PrixUnitaireUnite3QuantiteExportee,
            PrixUnitaireUnite3QuantiteImportee = updateDto.PrixUnitaireUnite3QuantiteImportee,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            valeurBoursiere.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            valeurBoursiere.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return valeurBoursiere;
    }
}
