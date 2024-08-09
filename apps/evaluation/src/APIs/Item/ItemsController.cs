using Microsoft.AspNetCore.Mvc;

namespace Evaluation.APIs;

[ApiController()]
public class ItemsController : ItemsControllerBase
{
    public ItemsController(IItemsService service)
        : base(service) { }
}
