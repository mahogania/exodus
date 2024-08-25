using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ShProfilsExtensions
{
    public static ShProfil ToDto(this ShProfilDbModel model)
    {
        return new ShProfil
        {
            CodeClassificationInferieureSh = model.CodeClassificationInferieureSh,
            CodeClassificationSuperieureSh = model.CodeClassificationSuperieureSh,
            CodeSh = model.CodeSh,
            CreatedAt = model.CreatedAt,
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

    public static ShProfilDbModel ToModel(
        this ShProfilUpdateInput updateDto,
        ShProfilWhereUniqueInput uniqueId
    )
    {
        var shProfil = new ShProfilDbModel
        {
            Id = uniqueId.Id,
            CodeClassificationInferieureSh = updateDto.CodeClassificationInferieureSh,
            CodeClassificationSuperieureSh = updateDto.CodeClassificationSuperieureSh,
            CodeSh = updateDto.CodeSh,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            SuppressionOn = updateDto.SuppressionOn,
            UtiliseOn = updateDto.UtiliseOn
        };

        if (updateDto.CreatedAt != null)
        {
            shProfil.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            shProfil.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return shProfil;
    }
}
