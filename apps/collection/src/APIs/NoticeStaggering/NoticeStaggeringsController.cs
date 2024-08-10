using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class NoticeStaggeringsController : NoticeStaggeringsControllerBase
{
    public NoticeStaggeringsController(INoticeStaggeringsService service)
        : base(service)
    {
    }
}
