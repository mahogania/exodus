using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class ManagementsController : ManagementsControllerBase
{
    public ManagementsController(IManagementsService service)
        : base(service)
    {
    }
}
