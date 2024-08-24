using Control.Infrastructure;

namespace Control.APIs;

public class RawMaterialsService : RawMaterialsServiceBase
{
    public RawMaterialsService(ControlDbContext context)
        : base(context) { }
}
