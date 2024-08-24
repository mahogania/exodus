using Control.Infrastructure;

namespace Control.APIs;

public class ImportCarnetControlsService : ImportCarnetControlsServiceBase
{
    public ImportCarnetControlsService(ControlDbContext context)
        : base(context) { }
}
