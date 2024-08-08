using Fret.APIs.Dtos;
using Fret.Infrastructure.Models;

namespace Fret.APIs.Extensions;

public static class ContainersExtensions
{
    public static Container ToDto(this ContainerDbModel model)
    {
        return new Container
        {
            CodeDeLUnitDeColis = model.CodeDeLUnitDeColis,
            CodeDeTypeDeConteneur = model.CodeDeTypeDeConteneur,
            CreatedAt = model.CreatedAt,
            DateEtHeureDeModificationFinale = model.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = model.DateEtHeureDePremierEnregistrement,
            Id = model.Id,
            IdDuModificateurFinal = model.IdDuModificateurFinal,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            NDeConteneur = model.NDeConteneur,
            NDeSQuenceDeBl = model.NDeSQuenceDeBl,
            NDeSQuenceDuConteneur = model.NDeSQuenceDuConteneur,
            NDeScell_1 = model.NDeScell_1,
            NDeScell_2 = model.NDeScell_2,
            NDeScell_3 = model.NDeScell_3,
            NombreDeColis = model.NombreDeColis,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                model.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            PoidsBrut = model.PoidsBrut,
            ResponsableDeScell_1 = model.ResponsableDeScell_1,
            ResponsableDeScell_2 = model.ResponsableDeScell_2,
            ResponsableDeScell_3 = model.ResponsableDeScell_3,
            SuppressionOn = model.SuppressionOn,
            TareDeConteneurSVide = model.TareDeConteneurSVide,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ContainerDbModel ToModel(
        this ContainerUpdateInput updateDto,
        ContainerWhereUniqueInput uniqueId
    )
    {
        var container = new ContainerDbModel
        {
            Id = uniqueId.Id,
            CodeDeLUnitDeColis = updateDto.CodeDeLUnitDeColis,
            CodeDeTypeDeConteneur = updateDto.CodeDeTypeDeConteneur,
            DateEtHeureDeModificationFinale = updateDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = updateDto.DateEtHeureDePremierEnregistrement,
            IdDuModificateurFinal = updateDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            NDeConteneur = updateDto.NDeConteneur,
            NDeSQuenceDeBl = updateDto.NDeSQuenceDeBl,
            NDeSQuenceDuConteneur = updateDto.NDeSQuenceDuConteneur,
            NDeScell_1 = updateDto.NDeScell_1,
            NDeScell_2 = updateDto.NDeScell_2,
            NDeScell_3 = updateDto.NDeScell_3,
            NombreDeColis = updateDto.NombreDeColis,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                updateDto.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            PoidsBrut = updateDto.PoidsBrut,
            ResponsableDeScell_1 = updateDto.ResponsableDeScell_1,
            ResponsableDeScell_2 = updateDto.ResponsableDeScell_2,
            ResponsableDeScell_3 = updateDto.ResponsableDeScell_3,
            SuppressionOn = updateDto.SuppressionOn,
            TareDeConteneurSVide = updateDto.TareDeConteneurSVide
        };

        if (updateDto.CreatedAt != null)
        {
            container.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            container.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return container;
    }
}
