using Control.Infrastructure;

namespace Control.APIs;

public class ImportCarnetRequestsService : ImportCarnetRequestsServiceBase
{
    public ImportCarnetRequestsService(ControlDbContext context)
        : base(context) { }
}
