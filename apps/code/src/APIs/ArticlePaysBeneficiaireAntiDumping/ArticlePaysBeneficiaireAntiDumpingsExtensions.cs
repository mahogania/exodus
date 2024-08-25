using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ArticlePaysBeneficiaireAntiDumpingsExtensions
{
    public static ArticlePaysBeneficiaireAntiDumping ToDto(
        this ArticlePaysBeneficiaireAntiDumpingDbModel model
    )
    {
        return new ArticlePaysBeneficiaireAntiDumping
        {
            CodeCategorieTarif = model.CodeCategorieTarif,
            CodePaysDroitsAntiDumping = model.CodePaysDroitsAntiDumping,
            CodeSh = model.CodeSh,
            CreatedAt = model.CreatedAt,
            DateHeureModificationFinale = model.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = model.DateHeurePremierEnregistrement,
            Id = model.Id,
            ModificateurFinalId = model.ModificateurFinalId,
            PremierEnregistrantId = model.PremierEnregistrantId,
            Sequence = model.Sequence,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ArticlePaysBeneficiaireAntiDumpingDbModel ToModel(
        this ArticlePaysBeneficiaireAntiDumpingUpdateInput updateDto,
        ArticlePaysBeneficiaireAntiDumpingWhereUniqueInput uniqueId
    )
    {
        var articlePaysBeneficiaireAntiDumping = new ArticlePaysBeneficiaireAntiDumpingDbModel
        {
            Id = uniqueId.Id,
            CodeCategorieTarif = updateDto.CodeCategorieTarif,
            CodePaysDroitsAntiDumping = updateDto.CodePaysDroitsAntiDumping,
            CodeSh = updateDto.CodeSh,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            Sequence = updateDto.Sequence,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            articlePaysBeneficiaireAntiDumping.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            articlePaysBeneficiaireAntiDumping.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return articlePaysBeneficiaireAntiDumping;
    }
}
