using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ArticlePeriodeApplicationTarifSpecialsController
    : ArticlePeriodeApplicationTarifSpecialsControllerBase
{
    public ArticlePeriodeApplicationTarifSpecialsController(
        IArticlePeriodeApplicationTarifSpecialsService service
    )
        : base(service) { }
}
