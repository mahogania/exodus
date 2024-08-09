using Collection.Infrastructure;

namespace Collection.APIs;

public class ArticlesService : ArticlesServiceBase
{
    public ArticlesService(CollectionDbContext context)
        : base(context) { }
}
