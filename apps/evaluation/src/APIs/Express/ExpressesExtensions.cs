using Evaluation.APIs.Dtos;
using Evaluation.Infrastructure.Models;

namespace Evaluation.APIs.Extensions;

public static class ExpressesExtensions
{
    public static Express ToDto(this ExpressDbModel model)
    {
        return new Express
        {
            CodeDeBureauDeDouane = model.CodeDeBureauDeDouane,
            CodeDeLOpRateurExpress = model.CodeDeLOpRateurExpress,
            CodeDePaysDeChargement = model.CodeDePaysDeChargement,
            CodeDeStatutDeTraitement = model.CodeDeStatutDeTraitement,
            CodeDeTypeDeTransmission = model.CodeDeTypeDeTransmission,
            CreatedAt = model.CreatedAt,
            DateDArrivE = model.DateDArrivE,
            DateDeDemande = model.DateDeDemande,
            DateEtHeureDeModificationFinale = model.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = model.DateEtHeureDePremierEnregistrement,
            Id = model.Id,
            IdDuFichierJoint = model.IdDuFichierJoint,
            IdDuModificateurFinal = model.IdDuModificateurFinal,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            NDeDemandeDeDDouanementExpress = model.NDeDemandeDeDDouanementExpress,
            NDeMasterBl = model.NDeMasterBl,
            NomDeLOpRateurExpress = model.NomDeLOpRateurExpress,
            NomDuNavire = model.NomDuNavire,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ExpressDbModel ToModel(
        this ExpressUpdateInput updateDto,
        ExpressWhereUniqueInput uniqueId
    )
    {
        var express = new ExpressDbModel
        {
            Id = uniqueId.Id,
            CodeDeBureauDeDouane = updateDto.CodeDeBureauDeDouane,
            CodeDeLOpRateurExpress = updateDto.CodeDeLOpRateurExpress,
            CodeDePaysDeChargement = updateDto.CodeDePaysDeChargement,
            CodeDeStatutDeTraitement = updateDto.CodeDeStatutDeTraitement,
            CodeDeTypeDeTransmission = updateDto.CodeDeTypeDeTransmission,
            DateDArrivE = updateDto.DateDArrivE,
            DateDeDemande = updateDto.DateDeDemande,
            DateEtHeureDeModificationFinale = updateDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = updateDto.DateEtHeureDePremierEnregistrement,
            IdDuFichierJoint = updateDto.IdDuFichierJoint,
            IdDuModificateurFinal = updateDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            NDeDemandeDeDDouanementExpress = updateDto.NDeDemandeDeDDouanementExpress,
            NDeMasterBl = updateDto.NDeMasterBl,
            NomDeLOpRateurExpress = updateDto.NomDeLOpRateurExpress,
            NomDuNavire = updateDto.NomDuNavire,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            express.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            express.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return express;
    }
}
