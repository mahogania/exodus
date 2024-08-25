using Control.Infrastructure;

namespace Control.APIs;

public class MacSuiteAtWithReexportationInTheStatesService
    : MacSuiteAtWithReexportationInTheStatesServiceBase
{
    public MacSuiteAtWithReexportationInTheStatesService(ControlDbContext context)
        : base(context)
    {
    }
}
