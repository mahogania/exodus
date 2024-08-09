using Statement.Infrastructure;

namespace Statement.APIs;

public class OperatorsService : OperatorsServiceBase
{
    public OperatorsService(StatementDbContext context)
        : base(context) { }
}
