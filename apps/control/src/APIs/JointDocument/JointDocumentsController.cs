using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class JointDocumentsController : JointDocumentsControllerBase
{
    public JointDocumentsController(IJointDocumentsService service)
        : base(service) { }
}
