using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ImportedMaterialWastesController : ImportedMaterialWastesControllerBase
{
    public ImportedMaterialWastesController(IImportedMaterialWastesService service)
        : base(service) { }
}
