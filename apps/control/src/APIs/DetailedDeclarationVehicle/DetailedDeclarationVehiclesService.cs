using Clre.Infrastructure;

namespace Clre.APIs;

public class DetailedDeclarationVehiclesService : DetailedDeclarationVehiclesServiceBase
{
    public DetailedDeclarationVehiclesService(ClreDbContext context)
        : base(context) { }
}
