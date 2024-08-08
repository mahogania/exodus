using Evaluation.Infrastructure;

namespace Evaluation.APIs;

public class DetailsService : DetailsServiceBase
{
    public DetailsService(EvaluationDbContext context)
        : base(context) { }
}
