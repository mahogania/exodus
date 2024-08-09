using Clre.Infrastructure;

namespace Clre.APIs;

public class InformationForDeterminingOriginsService : InformationForDeterminingOriginsServiceBase
{
    public InformationForDeterminingOriginsService(ClreDbContext context)
        : base(context) { }
}
