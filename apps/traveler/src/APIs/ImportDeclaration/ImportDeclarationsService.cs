using Traveler.Infrastructure;

namespace Traveler.APIs;

public class ImportDeclarationsService : ImportDeclarationsServiceBase
{
    public ImportDeclarationsService(TravelerDbContext context)
        : base(context) { }
}
