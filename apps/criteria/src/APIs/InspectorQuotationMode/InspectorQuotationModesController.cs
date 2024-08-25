using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class InspectorQuotationModesController : InspectorQuotationModesControllerBase
{
    public InspectorQuotationModesController(IInspectorQuotationModesService service)
        : base(service) { }
}
