using Control.Infrastructure;

namespace Control.APIs;

public class PlaceOfExecutionAtWithReexportationInTheStatesService
    : PlaceOfExecutionAtWithReexportationInTheStatesServiceBase
{
    public PlaceOfExecutionAtWithReexportationInTheStatesService(ControlDbContext context)
        : base(context) { }
}
