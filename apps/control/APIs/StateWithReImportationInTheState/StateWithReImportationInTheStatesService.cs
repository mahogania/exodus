using Control.Infrastructure;

namespace Control.APIs;

public class StateWithReImportationInTheStatesService : StateWithReImportationInTheStatesServiceBase
{
    public StateWithReImportationInTheStatesService(ControlDbContext context)
        : base(context)
    {
    }
}
