using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class CompensatoryProductsForPerfectionsController
    : CompensatoryProductsForPerfectionsControllerBase
{
    public CompensatoryProductsForPerfectionsController(
        ICompensatoryProductsForPerfectionsService service
    )
        : base(service) { }
}
