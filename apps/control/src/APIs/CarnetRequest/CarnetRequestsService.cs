using Control.Infrastructure;

namespace Control.APIs;

public class CarnetRequestsService : CarnetRequestsServiceBase
{
    public CarnetRequestsService(ControlDbContext context)
        : base(context) { }
}
