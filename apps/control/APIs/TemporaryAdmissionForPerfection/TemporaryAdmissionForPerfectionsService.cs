using Control.Infrastructure;

namespace Control.APIs;

public class TemporaryAdmissionForPerfectionsService : TemporaryAdmissionForPerfectionsServiceBase
{
    public TemporaryAdmissionForPerfectionsService(ControlDbContext context)
        : base(context)
    {
    }
}
