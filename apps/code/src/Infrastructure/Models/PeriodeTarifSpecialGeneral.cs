using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Infrastructure.Models;

[Table("PeriodeTarifSpecialGenerals")]
public class PeriodeTarifSpecialGeneralDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateDebutApplication { get; set; }

    public DateTime? DateFinApplication { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
