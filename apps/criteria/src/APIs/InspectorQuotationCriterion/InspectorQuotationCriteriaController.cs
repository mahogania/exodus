using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class InspectorQuotationCriteriaController : InspectorQuotationCriteriaControllerBase
{
    public InspectorQuotationCriteriaController(IInspectorQuotationCriteriaService service)
        : base(service) { }
}
