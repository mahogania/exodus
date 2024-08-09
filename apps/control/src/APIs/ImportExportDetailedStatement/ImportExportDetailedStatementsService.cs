using Clre.Infrastructure;

namespace Clre.APIs;

public class ImportExportDetailedStatementsService : ImportExportDetailedStatementsServiceBase
{
    public ImportExportDetailedStatementsService(ClreDbContext context)
        : base(context) { }
}
