using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ComparaisonShEntrePaysItemsController : ComparaisonShEntrePaysItemsControllerBase
{
    public ComparaisonShEntrePaysItemsController(IComparaisonShEntrePaysItemsService service)
        : base(service) { }
}
