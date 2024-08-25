using Control.Infrastructure;

namespace Control.APIs;

public class DirectImportationExportationsService : DirectImportationExportationsServiceBase
{
    public DirectImportationExportationsService(ControlDbContext context)
        : base(context)
    {
    }
}
