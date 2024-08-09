using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class TemporaryAdmissionForPerfectionsController
    : TemporaryAdmissionForPerfectionsControllerBase
{
    public TemporaryAdmissionForPerfectionsController(
        ITemporaryAdmissionForPerfectionsService service
    )
        : base(service) { }
}
