using Microsoft.AspNetCore.Mvc;

namespace Statement.APIs;

[ApiController()]
public class AttachmentsController : AttachmentsControllerBase
{
    public AttachmentsController(IAttachmentsService service)
        : base(service) { }
}
