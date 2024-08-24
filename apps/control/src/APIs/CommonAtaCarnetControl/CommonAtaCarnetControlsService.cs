using Control.Infrastructure;

namespace Control.APIs;

public class CommonAtaCarnetControlsService : CommonAtaCarnetControlsServiceBase
{
    public CommonAtaCarnetControlsService(ControlDbContext context)
        : base(context) { }
}
