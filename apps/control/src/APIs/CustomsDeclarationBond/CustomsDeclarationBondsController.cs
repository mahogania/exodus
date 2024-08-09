using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CustomsDeclarationBondsController : CustomsDeclarationBondsControllerBase
{
    public CustomsDeclarationBondsController(ICustomsDeclarationBondsService service)
        : base(service) { }
}
