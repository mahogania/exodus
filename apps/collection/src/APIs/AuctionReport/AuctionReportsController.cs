using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class AuctionReportsController : AuctionReportsControllerBase
{
    public AuctionReportsController(IAuctionReportsService service)
        : base(service)
    {
    }
}
