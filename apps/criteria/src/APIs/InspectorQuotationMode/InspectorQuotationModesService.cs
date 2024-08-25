using Criteria.Infrastructure;

namespace Criteria.APIs;

public class InspectorQuotationModesService : InspectorQuotationModesServiceBase
{
    public InspectorQuotationModesService(CriteriaDbContext context)
        : base(context) { }
}
