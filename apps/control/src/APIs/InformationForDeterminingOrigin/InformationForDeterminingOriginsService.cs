using Control.Infrastructure;

namespace Control.APIs;

public class InformationForDeterminingOriginsService : InformationForDeterminingOriginsServiceBase
{
    public InformationForDeterminingOriginsService(ControlDbContext context)
        : base(context) { }
}
