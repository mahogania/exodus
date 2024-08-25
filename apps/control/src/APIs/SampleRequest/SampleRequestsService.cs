using Control.Infrastructure;

namespace Control.APIs;

public class SampleRequestsService : SampleRequestsServiceBase
{
    public SampleRequestsService(ControlDbContext context)
        : base(context) { }
}
