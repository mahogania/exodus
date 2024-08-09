using Clre.Infrastructure;

namespace Clre.APIs;

public class ReplenishmentInDutyFreesService : ReplenishmentInDutyFreesServiceBase
{
    public ReplenishmentInDutyFreesService(ClreDbContext context)
        : base(context) { }
}
