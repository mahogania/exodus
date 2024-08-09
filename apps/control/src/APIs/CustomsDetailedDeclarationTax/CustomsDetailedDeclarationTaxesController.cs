using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CustomsDetailedDeclarationTaxesController
    : CustomsDetailedDeclarationTaxesControllerBase
{
    public CustomsDetailedDeclarationTaxesController(
        ICustomsDetailedDeclarationTaxesService service
    )
        : base(service) { }
}
