using Control.Infrastructure;

namespace Control.APIs;

public class ContainerValueAssessmentsService : ContainerValueAssessmentsServiceBase
{
    public ContainerValueAssessmentsService(ControlDbContext context)
        : base(context) { }
}
