using Evaluation.Infrastructure;

namespace Evaluation.APIs;

public class ExpressesService : ExpressesServiceBase
{
    public ExpressesService(EvaluationDbContext context)
        : base(context) { }
}
