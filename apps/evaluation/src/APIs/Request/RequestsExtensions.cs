using Evaluation.APIs.Dtos;
using Evaluation.Infrastructure.Models;

namespace Evaluation.APIs.Extensions;

public static class RequestsExtensions
{
    public static Request ToDto(this RequestDbModel model)
    {
        return new Request
        {
            AdresseDeLEntreprise = model.AdresseDeLEntreprise,
            CreatedAt = model.CreatedAt,
            DNominationCommerciale = model.DNominationCommerciale,
            DateEtHeureDeModificationFinale = model.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = model.DateEtHeureDePremierEnregistrement,
            EmailDeLOpRateur = model.EmailDeLOpRateur,
            Id = model.Id,
            IdDuFichierJoint = model.IdDuFichierJoint,
            IdDuModificateurFinal = model.IdDuModificateurFinal,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            MarqueDeLArticle = model.MarqueDeLArticle,
            NAlerte = model.NAlerte,
            NDeTlPhonePortableDeLOpRateur = model.NDeTlPhonePortableDeLOpRateur,
            NFaxDeLOpRateur = model.NFaxDeLOpRateur,
            NTlPhoneDeLOpRateur = model.NTlPhoneDeLOpRateur,
            NiuDeLEntreprise = model.NiuDeLEntreprise,
            NomDeLEntreprise = model.NomDeLEntreprise,
            Remarque = model.Remarque,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static RequestDbModel ToModel(
        this RequestUpdateInput updateDto,
        RequestWhereUniqueInput uniqueId
    )
    {
        var request = new RequestDbModel
        {
            Id = uniqueId.Id,
            AdresseDeLEntreprise = updateDto.AdresseDeLEntreprise,
            DNominationCommerciale = updateDto.DNominationCommerciale,
            DateEtHeureDeModificationFinale = updateDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = updateDto.DateEtHeureDePremierEnregistrement,
            EmailDeLOpRateur = updateDto.EmailDeLOpRateur,
            IdDuFichierJoint = updateDto.IdDuFichierJoint,
            IdDuModificateurFinal = updateDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            MarqueDeLArticle = updateDto.MarqueDeLArticle,
            NAlerte = updateDto.NAlerte,
            NDeTlPhonePortableDeLOpRateur = updateDto.NDeTlPhonePortableDeLOpRateur,
            NFaxDeLOpRateur = updateDto.NFaxDeLOpRateur,
            NTlPhoneDeLOpRateur = updateDto.NTlPhoneDeLOpRateur,
            NiuDeLEntreprise = updateDto.NiuDeLEntreprise,
            NomDeLEntreprise = updateDto.NomDeLEntreprise,
            Remarque = updateDto.Remarque,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            request.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            request.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return request;
    }
}
