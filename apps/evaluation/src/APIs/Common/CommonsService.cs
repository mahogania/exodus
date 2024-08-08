using Evaluation.Infrastructure;

namespace Evaluation.APIs;

public class CommonsService : CommonsServiceBase
{
    public CommonsService(EvaluationDbContext context)
        : base(context) { }
}
