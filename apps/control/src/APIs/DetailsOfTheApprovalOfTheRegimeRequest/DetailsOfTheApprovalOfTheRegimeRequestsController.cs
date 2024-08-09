using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class DetailsOfTheApprovalOfTheRegimeRequestsController
    : DetailsOfTheApprovalOfTheRegimeRequestsControllerBase
{
    public DetailsOfTheApprovalOfTheRegimeRequestsController(
        IDetailsOfTheApprovalOfTheRegimeRequestsService service
    )
        : base(service) { }
}
