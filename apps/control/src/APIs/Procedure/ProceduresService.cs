using Control.Infrastructure;

namespace Control.APIs;

public class ProceduresService : ProceduresServiceBase
{
    public ProceduresService(ControlDbContext context)
        : base(context) { }
}
