namespace Code.APIs.Dtos;

public class ArticlePeriodeApplicationTarifSpecialCreateInput
{
    public string? CodeCategorieTarif { get; set; }

    public string? CodeSh { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateDebutApplication { get; set; }

    public DateTime? DateFinApplication { get; set; }

    public string? Id { get; set; }

    public string? Sequence { get; set; }

    public DateTime UpdatedAt { get; set; }
}
