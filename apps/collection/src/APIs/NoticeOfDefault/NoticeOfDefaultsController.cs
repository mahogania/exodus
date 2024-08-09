using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class NoticeOfDefaultsController : NoticeOfDefaultsControllerBase
{
    public NoticeOfDefaultsController(INoticeOfDefaultsService service)
        : base(service) { }
}
