using Traveler.Infrastructure;

namespace Traveler.APIs;

public class ExitVouchersService : ExitVouchersServiceBase
{
    public ExitVouchersService(TravelerDbContext context)
        : base(context) { }
}
