using Criteria.Infrastructure;

namespace Criteria.APIs;

public class InspectorRatingCriteriaService : InspectorRatingCriteriaServiceBase
{
    public InspectorRatingCriteriaService(CriteriaDbContext context)
        : base(context) { }
}
