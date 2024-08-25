using Code.Infrastructure;

namespace Code.APIs;

public class ArticlePeriodeApplicationTarifSpecialsService
    : ArticlePeriodeApplicationTarifSpecialsServiceBase
{
    public ArticlePeriodeApplicationTarifSpecialsService(CodeDbContext context)
        : base(context) { }
}
