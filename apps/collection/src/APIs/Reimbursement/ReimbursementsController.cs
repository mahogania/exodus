using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class ReimbursementsController : ReimbursementsControllerBase
{
    public ReimbursementsController(IReimbursementsService service)
        : base(service) { }
}
