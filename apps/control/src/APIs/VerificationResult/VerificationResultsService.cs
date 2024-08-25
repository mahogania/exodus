using Control.Infrastructure;

namespace Control.APIs;

public class VerificationResultsService : VerificationResultsServiceBase
{
    public VerificationResultsService(ControlDbContext context)
        : base(context) { }
}
