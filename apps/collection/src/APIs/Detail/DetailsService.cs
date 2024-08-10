using Collection.Infrastructure;

namespace Collection.APIs;

public class DetailsService : DetailsServiceBase
{
    public DetailsService(CollectionDbContext context)
        : base(context)
    {
    }
}
