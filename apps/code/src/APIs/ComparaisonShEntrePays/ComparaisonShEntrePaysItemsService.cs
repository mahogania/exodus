using Code.Infrastructure;

namespace Code.APIs;

public class ComparaisonShEntrePaysItemsService : ComparaisonShEntrePaysItemsServiceBase
{
    public ComparaisonShEntrePaysItemsService(CodeDbContext context)
        : base(context) { }
}
