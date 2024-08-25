using Control.Infrastructure;

namespace Control.APIs;

public class FinalExportFollowedByReimportationInTheStatesService
    : FinalExportFollowedByReimportationInTheStatesServiceBase
{
    public FinalExportFollowedByReimportationInTheStatesService(ControlDbContext context)
        : base(context)
    {
    }
}
