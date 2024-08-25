using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("CommonDetailedDeclarationCustomsValueAssessments")]
public class CommonDetailedDeclarationCustomsValueAssessmentDbModel
{
    [Required] public DateTime CreatedAt { get; set; }

    [Key] [Required] public string Id { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}
