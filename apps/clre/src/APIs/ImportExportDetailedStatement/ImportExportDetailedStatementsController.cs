using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ImportExportDetailedStatementsController : ImportExportDetailedStatementsControllerBase
{
    public ImportExportDetailedStatementsController(IImportExportDetailedStatementsService service)
        : base(service) { }
}
