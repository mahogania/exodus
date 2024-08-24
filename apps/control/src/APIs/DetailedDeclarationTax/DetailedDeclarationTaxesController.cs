using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class DetailedDeclarationTaxesController : DetailedDeclarationTaxesControllerBase
{
    public DetailedDeclarationTaxesController(IDetailedDeclarationTaxesService service)
        : base(service) { }
}
