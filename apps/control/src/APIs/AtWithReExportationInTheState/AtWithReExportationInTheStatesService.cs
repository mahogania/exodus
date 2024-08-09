using Control.Infrastructure;

namespace Control.APIs;

public class AtWithReExportationInTheStatesService : AtWithReExportationInTheStatesServiceBase
{
    public AtWithReExportationInTheStatesService(ControlDbContext context)
        : base(context) { }
}
