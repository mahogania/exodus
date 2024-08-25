using Criteria.Infrastructure;

namespace Criteria.APIs;

public class InspectorRatingCriteriaInspectorsService : InspectorRatingCriteriaInspectorsServiceBase
{
    public InspectorRatingCriteriaInspectorsService(CriteriaDbContext context)
        : base(context) { }
}
