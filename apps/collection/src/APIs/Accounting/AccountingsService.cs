using Collection.Infrastructure;

namespace Collection.APIs;

public class AccountingsService : AccountingsServiceBase
{
    public AccountingsService(CollectionDbContext context)
        : base(context)
    {
    }
}
