using Code.Infrastructure;

namespace Code.APIs;

public class ArticlePeriodeApplicationTarifNormalsService
    : ArticlePeriodeApplicationTarifNormalsServiceBase
{
    public ArticlePeriodeApplicationTarifNormalsService(CodeDbContext context)
        : base(context) { }
}
