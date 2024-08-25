using Control.Infrastructure;

namespace Control.APIs;

public class AnalysisRequestsService : AnalysisRequestsServiceBase
{
    public AnalysisRequestsService(ControlDbContext context)
        : base(context) { }
}
