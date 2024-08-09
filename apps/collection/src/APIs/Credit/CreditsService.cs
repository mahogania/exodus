using Collection.Infrastructure;

namespace Collection.APIs;

public class CreditsService : CreditsServiceBase
{
    public CreditsService(CollectionDbContext context)
        : base(context) { }
}
