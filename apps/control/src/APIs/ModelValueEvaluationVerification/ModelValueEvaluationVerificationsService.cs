using Control.Infrastructure;

namespace Control.APIs;

public class ModelValueEvaluationVerificationsService : ModelValueEvaluationVerificationsServiceBase
{
    public ModelValueEvaluationVerificationsService(ControlDbContext context)
        : base(context) { }
}
