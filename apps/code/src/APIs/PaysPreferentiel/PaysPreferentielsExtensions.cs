using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class PaysPreferentielsExtensions
{
    public static PaysPreferentiel ToDto(this PaysPreferentielDbModel model)
    {
        return new PaysPreferentiel
        {
            CodeDePays = model.CodeDePays,
            CodePreferentiel = model.CodePreferentiel,
            CreatedAt = model.CreatedAt,
            DateDebutApplicationPreference = model.DateDebutApplicationPreference,
            DateFinApplicationConvention = model.DateFinApplicationConvention,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            PremierEnregistrantId = model.PremierEnregistrantId,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
            UtiliseOn = model.UtiliseOn,
        };
    }

    public static PaysPreferentielDbModel ToModel(
        this PaysPreferentielUpdateInput updateDto,
        PaysPreferentielWhereUniqueInput uniqueId
    )
    {
        var paysPreferentiel = new PaysPreferentielDbModel
        {
            Id = uniqueId.Id,
            CodeDePays = updateDto.CodeDePays,
            CodePreferentiel = updateDto.CodePreferentiel,
            DateDebutApplicationPreference = updateDto.DateDebutApplicationPreference,
            DateFinApplicationConvention = updateDto.DateFinApplicationConvention,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            SuppressionOn = updateDto.SuppressionOn,
            UtiliseOn = updateDto.UtiliseOn
        };

        if (updateDto.CreatedAt != null)
        {
            paysPreferentiel.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            paysPreferentiel.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return paysPreferentiel;
    }
}
