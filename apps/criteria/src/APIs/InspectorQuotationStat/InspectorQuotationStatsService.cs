using Criteria.Infrastructure;

namespace Criteria.APIs;

public class InspectorQuotationStatsService : InspectorQuotationStatsServiceBase
{
    public InspectorQuotationStatsService(CriteriaDbContext context)
        : base(context) { }
}
