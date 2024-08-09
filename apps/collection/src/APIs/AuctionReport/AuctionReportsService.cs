using Collection.Infrastructure;

namespace Collection.APIs;

public class AuctionReportsService : AuctionReportsServiceBase
{
    public AuctionReportsService(CollectionDbContext context)
        : base(context) { }
}
