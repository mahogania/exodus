using Collection.Infrastructure;

namespace Collection.APIs;

public class PaymentsService : PaymentsServiceBase
{
    public PaymentsService(CollectionDbContext context)
        : base(context)
    {
    }
}
