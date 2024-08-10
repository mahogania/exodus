using Control.Infrastructure;

namespace Control.APIs;

public class ImportedGoodsInformationsService : ImportedGoodsInformationsServiceBase
{
    public ImportedGoodsInformationsService(ControlDbContext context)
        : base(context)
    {
    }
}
