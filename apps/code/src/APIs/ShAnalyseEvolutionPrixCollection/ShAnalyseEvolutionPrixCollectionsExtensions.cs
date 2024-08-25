using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ShAnalyseEvolutionPrixCollectionsExtensions
{
    public static ShAnalyseEvolutionPrixCollection ToDto(
        this ShAnalyseEvolutionPrixCollectionDbModel model
    )
    {
        return new ShAnalyseEvolutionPrixCollection
        {
            AnneeAddition = model.AnneeAddition,
            CodeChampPeriodeAddition = model.CodeChampPeriodeAddition,
            CodeSh = model.CodeSh,
            CreatedAt = model.CreatedAt,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            MoisAddition = model.MoisAddition,
            MontantNcyFactureDernierePeriodeAddition =
                model.MontantNcyFactureDernierePeriodeAddition,
            MontantNcyFactureMoisAddition = model.MontantNcyFactureMoisAddition,
            NombreDeclarationsDernierePeriodeAddition =
                model.NombreDeclarationsDernierePeriodeAddition,
            NombreDeclarationsMoisAddition = model.NombreDeclarationsMoisAddition,
            PremierEnregistrantId = model.PremierEnregistrantId,
            SuppressionOn = model.SuppressionOn,
            TauxAugmentationMontantFacture = model.TauxAugmentationMontantFacture,
            TauxAugmentationNombreDeclarations = model.TauxAugmentationNombreDeclarations,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ShAnalyseEvolutionPrixCollectionDbModel ToModel(
        this ShAnalyseEvolutionPrixCollectionUpdateInput updateDto,
        ShAnalyseEvolutionPrixCollectionWhereUniqueInput uniqueId
    )
    {
        var shAnalyseEvolutionPrixCollection = new ShAnalyseEvolutionPrixCollectionDbModel
        {
            Id = uniqueId.Id,
            AnneeAddition = updateDto.AnneeAddition,
            CodeChampPeriodeAddition = updateDto.CodeChampPeriodeAddition,
            CodeSh = updateDto.CodeSh,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            MoisAddition = updateDto.MoisAddition,
            MontantNcyFactureDernierePeriodeAddition =
                updateDto.MontantNcyFactureDernierePeriodeAddition,
            MontantNcyFactureMoisAddition = updateDto.MontantNcyFactureMoisAddition,
            NombreDeclarationsDernierePeriodeAddition =
                updateDto.NombreDeclarationsDernierePeriodeAddition,
            NombreDeclarationsMoisAddition = updateDto.NombreDeclarationsMoisAddition,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            SuppressionOn = updateDto.SuppressionOn,
            TauxAugmentationMontantFacture = updateDto.TauxAugmentationMontantFacture,
            TauxAugmentationNombreDeclarations = updateDto.TauxAugmentationNombreDeclarations
        };

        if (updateDto.CreatedAt != null)
        {
            shAnalyseEvolutionPrixCollection.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            shAnalyseEvolutionPrixCollection.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return shAnalyseEvolutionPrixCollection;
    }
}
