using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ValueAssessmentsController : ValueAssessmentsControllerBase
{
    public ValueAssessmentsController(IValueAssessmentsService service)
        : base(service) { }
}
