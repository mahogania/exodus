using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class RefundRequestsController : RefundRequestsControllerBase
{
    public RefundRequestsController(IRefundRequestsService service)
        : base(service)
    {
    }
}
