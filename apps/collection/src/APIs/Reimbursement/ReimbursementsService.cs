using Collection.Infrastructure;

namespace Collection.APIs;

public class ReimbursementsService : ReimbursementsServiceBase
{
    public ReimbursementsService(CollectionDbContext context)
        : base(context) { }
}
