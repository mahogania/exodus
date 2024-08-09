using Clre.Infrastructure;

namespace Clre.APIs;

public class StateWithReImportationInTheStatesService : StateWithReImportationInTheStatesServiceBase
{
    public StateWithReImportationInTheStatesService(ClreDbContext context)
        : base(context) { }
}
