using Control.Infrastructure;

namespace Control.APIs;

public class ExportedOrToBeExportedGoodsInformationsService
    : ExportedOrToBeExportedGoodsInformationsServiceBase
{
    public ExportedOrToBeExportedGoodsInformationsService(ControlDbContext context)
        : base(context)
    {
    }
}
