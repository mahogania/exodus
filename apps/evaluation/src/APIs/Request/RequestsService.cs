using Evaluation.Infrastructure;

namespace Evaluation.APIs;

public class RequestsService : RequestsServiceBase
{
    public RequestsService(EvaluationDbContext context)
        : base(context) { }
}
