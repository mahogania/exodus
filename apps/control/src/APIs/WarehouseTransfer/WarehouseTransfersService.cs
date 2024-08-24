using Control.Infrastructure;

namespace Control.APIs;

public class WarehouseTransfersService : WarehouseTransfersServiceBase
{
    public WarehouseTransfersService(ControlDbContext context)
        : base(context) { }
}
