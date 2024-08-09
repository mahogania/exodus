using Fret.APIs.Dtos;
using Fret.Infrastructure.Models;

namespace Fret.APIs.Extensions;

public static class TrailersExtensions
{
    public static Trailer ToDto(this TrailerDbModel model)
    {
        return new Trailer
        {
            CreatedAt = model.CreatedAt,
            DateEtHeureDeModificationFinale = model.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = model.DateEtHeureDePremierEnregistrement,
            GabaritDeRemorque = model.GabaritDeRemorque,
            Id = model.Id,
            IdDuModificateurFinal = model.IdDuModificateurFinal,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            NDImmatriculationDuVHicule = model.NDImmatriculationDuVHicule,
            NDeChSsis = model.NDeChSsis,
            NDeSQuenceDeBl = model.NDeSQuenceDeBl,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                model.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            NumRoDeSRieDeLaRemorque = model.NumRoDeSRieDeLaRemorque,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static TrailerDbModel ToModel(
        this TrailerUpdateInput updateDto,
        TrailerWhereUniqueInput uniqueId
    )
    {
        var trailer = new TrailerDbModel
        {
            Id = uniqueId.Id,
            DateEtHeureDeModificationFinale = updateDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = updateDto.DateEtHeureDePremierEnregistrement,
            GabaritDeRemorque = updateDto.GabaritDeRemorque,
            IdDuModificateurFinal = updateDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            NDImmatriculationDuVHicule = updateDto.NDImmatriculationDuVHicule,
            NDeChSsis = updateDto.NDeChSsis,
            NDeSQuenceDeBl = updateDto.NDeSQuenceDeBl,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                updateDto.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            NumRoDeSRieDeLaRemorque = updateDto.NumRoDeSRieDeLaRemorque,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            trailer.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            trailer.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return trailer;
    }
}
