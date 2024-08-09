using Control.Infrastructure;

namespace Control.APIs;

public class PlaceOfExecutionAndWithReImportationInStatesService
    : PlaceOfExecutionAndWithReImportationInStatesServiceBase
{
    public PlaceOfExecutionAndWithReImportationInStatesService(ControlDbContext context)
        : base(context) { }
}
