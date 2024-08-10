using Control.Infrastructure;

namespace Control.APIs;

public class ReplenishmentInDutyFreesService : ReplenishmentInDutyFreesServiceBase
{
    public ReplenishmentInDutyFreesService(ControlDbContext context)
        : base(context)
    {
    }
}
