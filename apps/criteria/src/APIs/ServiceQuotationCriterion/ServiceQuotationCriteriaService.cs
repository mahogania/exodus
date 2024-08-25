using Criteria.Infrastructure;

namespace Criteria.APIs;

public class ServiceQuotationCriteriaService : ServiceQuotationCriteriaServiceBase
{
    public ServiceQuotationCriteriaService(CriteriaDbContext context)
        : base(context) { }
}
