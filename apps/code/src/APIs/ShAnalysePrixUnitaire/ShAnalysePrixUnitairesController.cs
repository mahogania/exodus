using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ShAnalysePrixUnitairesController : ShAnalysePrixUnitairesControllerBase
{
    public ShAnalysePrixUnitairesController(IShAnalysePrixUnitairesService service)
        : base(service) { }
}
