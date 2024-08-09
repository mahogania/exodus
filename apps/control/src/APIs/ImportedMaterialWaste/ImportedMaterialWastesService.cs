using Clre.Infrastructure;

namespace Clre.APIs;

public class ImportedMaterialWastesService : ImportedMaterialWastesServiceBase
{
    public ImportedMaterialWastesService(ClreDbContext context)
        : base(context) { }
}
