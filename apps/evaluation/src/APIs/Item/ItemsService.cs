using Evaluation.Infrastructure;

namespace Evaluation.APIs;

public class ItemsService : ItemsServiceBase
{
    public ItemsService(EvaluationDbContext context)
        : base(context) { }
}
