using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class FinesController : FinesControllerBase
{
    public FinesController(IFinesService service)
        : base(service) { }
}
