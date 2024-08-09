using Clre.Infrastructure;

namespace Clre.APIs;

public class ImportedGoodsInformationsService : ImportedGoodsInformationsServiceBase
{
    public ImportedGoodsInformationsService(ClreDbContext context)
        : base(context) { }
}
