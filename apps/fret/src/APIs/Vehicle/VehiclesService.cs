using Fret.Infrastructure;

namespace Fret.APIs;

public class VehiclesService : VehiclesServiceBase
{
    public VehiclesService(FretDbContext context)
        : base(context) { }
}
