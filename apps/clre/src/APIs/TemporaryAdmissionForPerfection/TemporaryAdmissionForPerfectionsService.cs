using Clre.Infrastructure;

namespace Clre.APIs;

public class TemporaryAdmissionForPerfectionsService : TemporaryAdmissionForPerfectionsServiceBase
{
    public TemporaryAdmissionForPerfectionsService(ClreDbContext context)
        : base(context) { }
}
