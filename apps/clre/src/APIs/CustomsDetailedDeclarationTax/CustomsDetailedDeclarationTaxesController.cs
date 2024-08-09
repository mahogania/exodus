using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class CustomsDetailedDeclarationTaxesController
    : CustomsDetailedDeclarationTaxesControllerBase
{
    public CustomsDetailedDeclarationTaxesController(
        ICustomsDetailedDeclarationTaxesService service
    )
        : base(service) { }
}
