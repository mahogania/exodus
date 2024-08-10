using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class PaymentsController : PaymentsControllerBase
{
    public PaymentsController(IPaymentsService service)
        : base(service)
    {
    }
}
