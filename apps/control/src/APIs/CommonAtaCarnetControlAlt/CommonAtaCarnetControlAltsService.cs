using Control.Infrastructure;

namespace Control.APIs;

public class CommonAtaCarnetControlAltsService : CommonAtaCarnetControlAltsServiceBase
{
    public CommonAtaCarnetControlAltsService(ControlDbContext context)
        : base(context) { }
}
