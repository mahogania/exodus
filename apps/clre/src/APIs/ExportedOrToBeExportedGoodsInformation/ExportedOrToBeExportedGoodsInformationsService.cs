using Clre.Infrastructure;

namespace Clre.APIs;

public class ExportedOrToBeExportedGoodsInformationsService
    : ExportedOrToBeExportedGoodsInformationsServiceBase
{
    public ExportedOrToBeExportedGoodsInformationsService(ClreDbContext context)
        : base(context) { }
}
