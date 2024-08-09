using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class CustomsDeclarationBondsController : CustomsDeclarationBondsControllerBase
{
    public CustomsDeclarationBondsController(ICustomsDeclarationBondsService service)
        : base(service) { }
}
