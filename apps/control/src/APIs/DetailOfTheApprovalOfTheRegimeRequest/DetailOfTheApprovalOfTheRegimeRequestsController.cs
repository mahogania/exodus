using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class DetailOfTheApprovalOfTheRegimeRequestsController
    : DetailOfTheApprovalOfTheRegimeRequestsControllerBase
{
    public DetailOfTheApprovalOfTheRegimeRequestsController(
        IDetailOfTheApprovalOfTheRegimeRequestsService service
    )
        : base(service) { }
}
