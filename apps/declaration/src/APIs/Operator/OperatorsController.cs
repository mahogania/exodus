using Microsoft.AspNetCore.Mvc;

namespace Statement.APIs;

[ApiController()]
public class OperatorsController : OperatorsControllerBase
{
    public OperatorsController(IOperatorsService service)
        : base(service) { }
}
