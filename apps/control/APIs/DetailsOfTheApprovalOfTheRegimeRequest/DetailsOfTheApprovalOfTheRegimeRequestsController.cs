using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class DetailsOfTheApprovalOfTheRegimeRequestsController
    : DetailsOfTheApprovalOfTheRegimeRequestsControllerBase
{
    public DetailsOfTheApprovalOfTheRegimeRequestsController(
        IDetailsOfTheApprovalOfTheRegimeRequestsService service
    )
        : base(service)
    {
    }
}
