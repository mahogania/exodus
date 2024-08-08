using Fret.APIs.Dtos;
using Fret.Infrastructure.Models;

namespace Fret.APIs.Extensions;

public static class TrainsExtensions
{
    public static Train ToDto(this TrainDbModel model)
    {
        return new Train
        {
            CreatedAt = model.CreatedAt,
            DateEtHeureDeModificationFinale = model.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = model.DateEtHeureDePremierEnregistrement,
            Id = model.Id,
            IdDuModificateurFinal = model.IdDuModificateurFinal,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            NDeSQuenceDeBl = model.NDeSQuenceDeBl,
            NDeWagon = model.NDeWagon,
            NEnregistrementDuTrain = model.NEnregistrementDuTrain,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                model.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            NumRoDeSRieDuTrain = model.NumRoDeSRieDuTrain,
            SuppressionOn = model.SuppressionOn,
            TypeDeWagon = model.TypeDeWagon,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static TrainDbModel ToModel(
        this TrainUpdateInput updateDto,
        TrainWhereUniqueInput uniqueId
    )
    {
        var train = new TrainDbModel
        {
            Id = uniqueId.Id,
            DateEtHeureDeModificationFinale = updateDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = updateDto.DateEtHeureDePremierEnregistrement,
            IdDuModificateurFinal = updateDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            NDeSQuenceDeBl = updateDto.NDeSQuenceDeBl,
            NDeWagon = updateDto.NDeWagon,
            NEnregistrementDuTrain = updateDto.NEnregistrementDuTrain,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                updateDto.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            NumRoDeSRieDuTrain = updateDto.NumRoDeSRieDuTrain,
            SuppressionOn = updateDto.SuppressionOn,
            TypeDeWagon = updateDto.TypeDeWagon
        };

        if (updateDto.CreatedAt != null)
        {
            train.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            train.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return train;
    }
}
