using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class PaysPreferentielsController : PaysPreferentielsControllerBase
{
    public PaysPreferentielsController(IPaysPreferentielsService service)
        : base(service) { }
}
