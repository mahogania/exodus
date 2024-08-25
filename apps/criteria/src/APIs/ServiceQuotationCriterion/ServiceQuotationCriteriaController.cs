using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class ServiceQuotationCriteriaController : ServiceQuotationCriteriaControllerBase
{
    public ServiceQuotationCriteriaController(IServiceQuotationCriteriaService service)
        : base(service) { }
}
