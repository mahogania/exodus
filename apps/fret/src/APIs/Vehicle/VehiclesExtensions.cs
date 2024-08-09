using Fret.APIs.Dtos;
using Fret.Infrastructure.Models;

namespace Fret.APIs.Extensions;

public static class VehiclesExtensions
{
    public static Vehicle ToDto(this VehicleDbModel model)
    {
        return new Vehicle
        {
            AnnEDeFabricationDeVHicule = model.AnnEDeFabricationDeVHicule,
            CodeDeFabricantDuVHicule = model.CodeDeFabricantDuVHicule,
            CodeDeModLeDuVHicule = model.CodeDeModLeDuVHicule,
            CreatedAt = model.CreatedAt,
            DateEtHeureDeModificationFinale = model.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = model.DateEtHeureDePremierEnregistrement,
            Id = model.Id,
            IdDuModificateurFinal = model.IdDuModificateurFinal,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            NDImmatriculationDuVHicule = model.NDImmatriculationDuVHicule,
            NDeChSsis = model.NDeChSsis,
            NDeSQuenceDeBl = model.NDeSQuenceDeBl,
            NombreDeCylindresDeMoteur = model.NombreDeCylindresDeMoteur,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                model.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            NumRoDeSQuenceDeVHicule = model.NumRoDeSQuenceDeVHicule,
            PoidsTotalEnCharge = model.PoidsTotalEnCharge,
            SuppressionOn = model.SuppressionOn,
            TypeDeVHicule = model.TypeDeVHicule,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static VehicleDbModel ToModel(
        this VehicleUpdateInput updateDto,
        VehicleWhereUniqueInput uniqueId
    )
    {
        var vehicle = new VehicleDbModel
        {
            Id = uniqueId.Id,
            AnnEDeFabricationDeVHicule = updateDto.AnnEDeFabricationDeVHicule,
            CodeDeFabricantDuVHicule = updateDto.CodeDeFabricantDuVHicule,
            CodeDeModLeDuVHicule = updateDto.CodeDeModLeDuVHicule,
            DateEtHeureDeModificationFinale = updateDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = updateDto.DateEtHeureDePremierEnregistrement,
            IdDuModificateurFinal = updateDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            NDImmatriculationDuVHicule = updateDto.NDImmatriculationDuVHicule,
            NDeChSsis = updateDto.NDeChSsis,
            NDeSQuenceDeBl = updateDto.NDeSQuenceDeBl,
            NombreDeCylindresDeMoteur = updateDto.NombreDeCylindresDeMoteur,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                updateDto.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            NumRoDeSQuenceDeVHicule = updateDto.NumRoDeSQuenceDeVHicule,
            PoidsTotalEnCharge = updateDto.PoidsTotalEnCharge,
            SuppressionOn = updateDto.SuppressionOn,
            TypeDeVHicule = updateDto.TypeDeVHicule
        };

        if (updateDto.CreatedAt != null)
        {
            vehicle.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            vehicle.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return vehicle;
    }
}
