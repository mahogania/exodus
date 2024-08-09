using Clre.Infrastructure;

namespace Clre.APIs;

public class WarehouseTransferPublicPrivatesService : WarehouseTransferPublicPrivatesServiceBase
{
    public WarehouseTransferPublicPrivatesService(ClreDbContext context)
        : base(context) { }
}
