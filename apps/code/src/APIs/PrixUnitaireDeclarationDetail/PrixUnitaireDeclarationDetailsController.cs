using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class PrixUnitaireDeclarationDetailsController : PrixUnitaireDeclarationDetailsControllerBase
{
    public PrixUnitaireDeclarationDetailsController(IPrixUnitaireDeclarationDetailsService service)
        : base(service) { }
}
