using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("Journals")]
public class JournalDbModel
{
    public List<CancellationRequestDbModel>? CancellationRequests { get; set; } =
        new List<CancellationRequestDbModel>();

    public List<CommonActiveGoodsRequestDbModel>? CommonActiveGoodsRequests { get; set; } =
        new List<CommonActiveGoodsRequestDbModel>();

    public string? CommonDetailedDeclarationId { get; set; }

    [ForeignKey(nameof(CommonDetailedDeclarationId))]
    public CommonDetailedDeclarationDbModel? CommonDetailedDeclaration { get; set; } = null;

    public List<CommonOriginCertificateRequestDbModel>? CommonOriginCertificateRequests { get; set; } =
        new List<CommonOriginCertificateRequestDbModel>();

    public List<CommonRegimeRequestDbModel>? CommonRegimeRequests { get; set; } =
        new List<CommonRegimeRequestDbModel>();

    [Required()]
    public DateTime CreatedAt { get; set; }

    public List<ForeignOperatorRequestDbModel>? ForeignOperatorRequests { get; set; } =
        new List<ForeignOperatorRequestDbModel>();

    [Key()]
    [Required()]
    public string Id { get; set; }

    public List<RecourseRequestDbModel>? RecourseRequests { get; set; } =
        new List<RecourseRequestDbModel>();

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
