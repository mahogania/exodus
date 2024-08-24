using Control.Infrastructure;

namespace Control.APIs;

public class JointDocumentsService : JointDocumentsServiceBase
{
    public JointDocumentsService(ControlDbContext context)
        : base(context) { }
}
