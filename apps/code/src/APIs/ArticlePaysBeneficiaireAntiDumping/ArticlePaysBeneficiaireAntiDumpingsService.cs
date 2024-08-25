using Code.Infrastructure;

namespace Code.APIs;

public class ArticlePaysBeneficiaireAntiDumpingsService
    : ArticlePaysBeneficiaireAntiDumpingsServiceBase
{
    public ArticlePaysBeneficiaireAntiDumpingsService(CodeDbContext context)
        : base(context) { }
}
