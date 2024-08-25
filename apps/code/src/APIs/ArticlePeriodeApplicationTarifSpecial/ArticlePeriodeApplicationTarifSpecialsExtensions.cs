using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ArticlePeriodeApplicationTarifSpecialsExtensions
{
    public static ArticlePeriodeApplicationTarifSpecial ToDto(
        this ArticlePeriodeApplicationTarifSpecialDbModel model
    )
    {
        return new ArticlePeriodeApplicationTarifSpecial
        {
            CodeCategorieTarif = model.CodeCategorieTarif,
            CodeSh = model.CodeSh,
            CreatedAt = model.CreatedAt,
            DateDebutApplication = model.DateDebutApplication,
            DateFinApplication = model.DateFinApplication,
            Id = model.Id,
            Sequence = model.Sequence,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ArticlePeriodeApplicationTarifSpecialDbModel ToModel(
        this ArticlePeriodeApplicationTarifSpecialUpdateInput updateDto,
        ArticlePeriodeApplicationTarifSpecialWhereUniqueInput uniqueId
    )
    {
        var articlePeriodeApplicationTarifSpecial = new ArticlePeriodeApplicationTarifSpecialDbModel
        {
            Id = uniqueId.Id,
            CodeCategorieTarif = updateDto.CodeCategorieTarif,
            CodeSh = updateDto.CodeSh,
            DateDebutApplication = updateDto.DateDebutApplication,
            DateFinApplication = updateDto.DateFinApplication,
            Sequence = updateDto.Sequence
        };

        if (updateDto.CreatedAt != null)
        {
            articlePeriodeApplicationTarifSpecial.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            articlePeriodeApplicationTarifSpecial.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return articlePeriodeApplicationTarifSpecial;
    }
}
