using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class OfficialReportsController : OfficialReportsControllerBase
{
    public OfficialReportsController(IOfficialReportsService service)
        : base(service) { }
}
