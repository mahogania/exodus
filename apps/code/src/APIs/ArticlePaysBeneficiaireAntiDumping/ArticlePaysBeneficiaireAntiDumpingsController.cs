using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ArticlePaysBeneficiaireAntiDumpingsController
    : ArticlePaysBeneficiaireAntiDumpingsControllerBase
{
    public ArticlePaysBeneficiaireAntiDumpingsController(
        IArticlePaysBeneficiaireAntiDumpingsService service
    )
        : base(service) { }
}
