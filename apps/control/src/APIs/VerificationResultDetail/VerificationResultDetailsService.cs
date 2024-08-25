using Control.Infrastructure;

namespace Control.APIs;

public class VerificationResultDetailsService : VerificationResultDetailsServiceBase
{
    public VerificationResultDetailsService(ControlDbContext context)
        : base(context) { }
}
