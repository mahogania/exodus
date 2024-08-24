using Control.Infrastructure;

namespace Control.APIs;

public class ValueAssessmentsService : ValueAssessmentsServiceBase
{
    public ValueAssessmentsService(ControlDbContext context)
        : base(context) { }
}
