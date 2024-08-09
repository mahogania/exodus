using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ImportedMaterialWastesController : ImportedMaterialWastesControllerBase
{
    public ImportedMaterialWastesController(IImportedMaterialWastesService service)
        : base(service) { }
}
