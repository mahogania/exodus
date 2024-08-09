using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class FinalExportFollowedByReimportationInTheStatesController
    : FinalExportFollowedByReimportationInTheStatesControllerBase
{
    public FinalExportFollowedByReimportationInTheStatesController(
        IFinalExportFollowedByReimportationInTheStatesService service
    )
        : base(service) { }
}
