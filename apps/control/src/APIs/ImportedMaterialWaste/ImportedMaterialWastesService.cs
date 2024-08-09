using Control.Infrastructure;

namespace Control.APIs;

public class ImportedMaterialWastesService : ImportedMaterialWastesServiceBase
{
    public ImportedMaterialWastesService(ControlDbContext context)
        : base(context) { }
}
