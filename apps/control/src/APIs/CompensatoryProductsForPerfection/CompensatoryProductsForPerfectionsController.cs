using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CompensatoryProductsForPerfectionsController
    : CompensatoryProductsForPerfectionsControllerBase
{
    public CompensatoryProductsForPerfectionsController(
        ICompensatoryProductsForPerfectionsService service
    )
        : base(service) { }
}
