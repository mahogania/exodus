using Clre.Infrastructure;

namespace Clre.APIs;

public class DirectImportationExportationsService : DirectImportationExportationsServiceBase
{
    public DirectImportationExportationsService(ClreDbContext context)
        : base(context) { }
}
