using Clre.Infrastructure;

namespace Clre.APIs;

public class MacSubjectToAuthorizationsService : MacSubjectToAuthorizationsServiceBase
{
    public MacSubjectToAuthorizationsService(ClreDbContext context)
        : base(context) { }
}
