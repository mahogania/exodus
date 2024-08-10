using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class NoticeTypesController : NoticeTypesControllerBase
{
    public NoticeTypesController(INoticeTypesService service)
        : base(service)
    {
    }
}
