using Collection.Infrastructure;

namespace Collection.APIs;

public class BondReleasesService : BondReleasesServiceBase
{
    public BondReleasesService(CollectionDbContext context)
        : base(context) { }
}
