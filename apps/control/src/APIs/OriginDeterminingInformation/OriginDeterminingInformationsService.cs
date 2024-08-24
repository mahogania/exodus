using Control.Infrastructure;

namespace Control.APIs;

public class OriginDeterminingInformationsService : OriginDeterminingInformationsServiceBase
{
    public OriginDeterminingInformationsService(ControlDbContext context)
        : base(context) { }
}
