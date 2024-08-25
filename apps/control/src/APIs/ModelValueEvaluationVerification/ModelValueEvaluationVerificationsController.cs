using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ModelValueEvaluationVerificationsController
    : ModelValueEvaluationVerificationsControllerBase
{
    public ModelValueEvaluationVerificationsController(
        IModelValueEvaluationVerificationsService service
    )
        : base(service) { }
}
