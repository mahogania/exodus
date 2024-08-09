using Statement.Infrastructure;

namespace Statement.APIs;

public class ContainersService : ContainersServiceBase
{
    public ContainersService(StatementDbContext context)
        : base(context) { }
}
