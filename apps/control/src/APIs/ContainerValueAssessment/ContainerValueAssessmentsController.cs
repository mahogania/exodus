using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ContainerValueAssessmentsController : ContainerValueAssessmentsControllerBase
{
    public ContainerValueAssessmentsController(IContainerValueAssessmentsService service)
        : base(service) { }
}
