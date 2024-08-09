using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ImportExportDetailedStatementsController : ImportExportDetailedStatementsControllerBase
{
    public ImportExportDetailedStatementsController(IImportExportDetailedStatementsService service)
        : base(service) { }
}
