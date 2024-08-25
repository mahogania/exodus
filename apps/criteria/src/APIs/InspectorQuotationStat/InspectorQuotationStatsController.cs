using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class InspectorQuotationStatsController : InspectorQuotationStatsControllerBase
{
    public InspectorQuotationStatsController(IInspectorQuotationStatsService service)
        : base(service) { }
}
