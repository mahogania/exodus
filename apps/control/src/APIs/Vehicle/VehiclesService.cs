using Control.Infrastructure;

namespace Control.APIs;

public class VehiclesService : VehiclesServiceBase
{
    public VehiclesService(ControlDbContext context)
        : base(context) { }
}
