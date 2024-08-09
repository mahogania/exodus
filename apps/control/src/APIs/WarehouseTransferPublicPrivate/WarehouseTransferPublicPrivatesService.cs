using Control.Infrastructure;

namespace Control.APIs;

public class WarehouseTransferPublicPrivatesService : WarehouseTransferPublicPrivatesServiceBase
{
    public WarehouseTransferPublicPrivatesService(ControlDbContext context)
        : base(context) { }
}
