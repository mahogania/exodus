using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Infrastructure.Models;

[Table("ArticlePeriodeApplicationTarifSpecials")]
public class ArticlePeriodeApplicationTarifSpecialDbModel
{
    [StringLength(1000)]
    public string? CodeCategorieTarif { get; set; }

    [StringLength(1000)]
    public string? CodeSh { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateDebutApplication { get; set; }

    public DateTime? DateFinApplication { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Sequence { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
