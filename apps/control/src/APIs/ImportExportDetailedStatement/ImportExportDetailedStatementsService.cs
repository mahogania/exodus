using Control.Infrastructure;

namespace Control.APIs;

public class ImportExportDetailedStatementsService : ImportExportDetailedStatementsServiceBase
{
    public ImportExportDetailedStatementsService(ControlDbContext context)
        : base(context) { }
}
