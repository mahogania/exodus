using Collection.Infrastructure;

namespace Collection.APIs;

public class ManageRecklessBiddersService : ManageRecklessBiddersServiceBase
{
    public ManageRecklessBiddersService(CollectionDbContext context)
        : base(context)
    {
    }
}
