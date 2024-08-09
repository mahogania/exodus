using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class TemporaryAdmissionForPerfectionsController
    : TemporaryAdmissionForPerfectionsControllerBase
{
    public TemporaryAdmissionForPerfectionsController(
        ITemporaryAdmissionForPerfectionsService service
    )
        : base(service) { }
}
