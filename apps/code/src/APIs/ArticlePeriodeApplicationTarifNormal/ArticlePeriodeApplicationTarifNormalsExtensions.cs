using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ArticlePeriodeApplicationTarifNormalsExtensions
{
    public static ArticlePeriodeApplicationTarifNormal ToDto(
        this ArticlePeriodeApplicationTarifNormalDbModel model
    )
    {
        return new ArticlePeriodeApplicationTarifNormal
        {
            CodeSh = model.CodeSh,
            CreatedAt = model.CreatedAt,
            DateDebutApplication = model.DateDebutApplication,
            DateFinApplication = model.DateFinApplication,
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

    public static ArticlePeriodeApplicationTarifNormalDbModel ToModel(
        this ArticlePeriodeApplicationTarifNormalUpdateInput updateDto,
        ArticlePeriodeApplicationTarifNormalWhereUniqueInput uniqueId
    )
    {
        var articlePeriodeApplicationTarifNormal = new ArticlePeriodeApplicationTarifNormalDbModel
        {
            Id = uniqueId.Id,
            CodeSh = updateDto.CodeSh,
            DateDebutApplication = updateDto.DateDebutApplication,
            DateFinApplication = updateDto.DateFinApplication,
            DateHeureModificationFinale = updateDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = updateDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = updateDto.ModificateurFinalId,
            PremierEnregistrantId = updateDto.PremierEnregistrantId,
            Sequence = updateDto.Sequence,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            articlePeriodeApplicationTarifNormal.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            articlePeriodeApplicationTarifNormal.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return articlePeriodeApplicationTarifNormal;
    }
}
