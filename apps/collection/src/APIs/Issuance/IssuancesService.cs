using Collection.Infrastructure;

namespace Collection.APIs;

public class IssuancesService : IssuancesServiceBase
{
    public IssuancesService(CollectionDbContext context)
        : base(context) { }
}
