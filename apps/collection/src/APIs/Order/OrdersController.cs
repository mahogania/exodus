using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
