using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ValueAssessments")]
public class ValueAssessmentDbModel
{
    public List<ArticleAssessmentDbModel>? Articles { get; set; } =
        new List<ArticleAssessmentDbModel>();

    public CommonDetailedDeclarationDbModel? CommonDetailedDeclarations { get; set; } = null;

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
