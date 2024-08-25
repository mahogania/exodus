using Criteria.Infrastructure;

namespace Criteria.APIs;

public class InspectorQuotationCriteriaService : InspectorQuotationCriteriaServiceBase
{
    public InspectorQuotationCriteriaService(CriteriaDbContext context)
        : base(context) { }
}
