using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ComparaisonShEntrePaysItemsExtensions
{
    public static ComparaisonShEntrePays ToDto(this ComparaisonShEntrePaysDbModel model)
    {
        return new ComparaisonShEntrePays
        {
            CodeEmetteurSh = model.CodeEmetteurSh,
            CodeSh = model.CodeSh,
            CreatedAt = model.CreatedAt,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            DescriptionSh = model.DescriptionSh,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            PremierEnregistrantId = model.PremierEnregistrantId,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ComparaisonShEntrePaysDbModel ToModel(
        this ComparaisonShEntrePaysUpdateInput updateDto,
        ComparaisonShEntrePaysWhereUniqueInput uniqueId
    )
    {
        var comparaisonShEntrePays = new ComparaisonShEntrePaysDbModel
        {
            Id = uniqueId.Id,
            CodeEmetteurSh = updateDto.CodeEmetteurSh,
            CodeSh = updateDto.CodeSh,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            DescriptionSh = updateDto.DescriptionSh,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            comparaisonShEntrePays.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            comparaisonShEntrePays.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return comparaisonShEntrePays;
    }
}
