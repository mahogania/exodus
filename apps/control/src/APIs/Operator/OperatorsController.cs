using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class OperatorsController : OperatorsControllerBase
{
    public OperatorsController(IOperatorsService service)
        : base(service) { }
}
