using Control.Infrastructure;

namespace Control.APIs;

public class DetailedDeclarationVehiclesService : DetailedDeclarationVehiclesServiceBase
{
    public DetailedDeclarationVehiclesService(ControlDbContext context)
        : base(context)
    {
    }
}
