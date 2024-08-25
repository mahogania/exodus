using Code.APIs.Dtos;
using Code.Infrastructure.Models;

namespace Code.APIs.Extensions;

public static class ArticlePaysPartenaireConventionDouanieresExtensions
{
    public static ArticlePaysPartenaireConventionDouaniere ToDto(
        this ArticlePaysPartenaireConventionDouaniereDbModel model
    )
    {
        return new ArticlePaysPartenaireConventionDouaniere
        {
            CodeCategorieTarif = model.CodeCategorieTarif,
            CodePaysPreferentiel = model.CodePaysPreferentiel,
            CodePreferentiel = model.CodePreferentiel,
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

    public static ArticlePaysPartenaireConventionDouaniereDbModel ToModel(
        this ArticlePaysPartenaireConventionDouaniereUpdateInput updateDto,
        ArticlePaysPartenaireConventionDouaniereWhereUniqueInput uniqueId
    )
    {
        var articlePaysPartenaireConventionDouaniere =
            new ArticlePaysPartenaireConventionDouaniereDbModel
            {
                Id = uniqueId.Id,
                CodeCategorieTarif = updateDto.CodeCategorieTarif,
                CodePaysPreferentiel = updateDto.CodePaysPreferentiel,
                CodePreferentiel = updateDto.CodePreferentiel,
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
            articlePaysPartenaireConventionDouaniere.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            articlePaysPartenaireConventionDouaniere.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return articlePaysPartenaireConventionDouaniere;
    }
}
