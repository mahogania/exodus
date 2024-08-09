using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class ReceptionsController : ReceptionsControllerBase
{
    public ReceptionsController(IReceptionsService service)
        : base(service) { }
}
