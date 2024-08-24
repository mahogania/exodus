using Control.Infrastructure;

namespace Control.APIs;

public class OperatorsService : OperatorsServiceBase
{
    public OperatorsService(ControlDbContext context)
        : base(context) { }
}
