using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class NoticeCancellationsController : NoticeCancellationsControllerBase
{
    public NoticeCancellationsController(INoticeCancellationsService service)
        : base(service) { }
}
