using Control.Infrastructure;

namespace Control.APIs;

public class CarnetControlsService : CarnetControlsServiceBase
{
    public CarnetControlsService(ControlDbContext context)
        : base(context) { }
}
