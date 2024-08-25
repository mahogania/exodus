using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ArticlePeriodeApplicationTarifNormalsController
    : ArticlePeriodeApplicationTarifNormalsControllerBase
{
    public ArticlePeriodeApplicationTarifNormalsController(
        IArticlePeriodeApplicationTarifNormalsService service
    )
        : base(service) { }
}
