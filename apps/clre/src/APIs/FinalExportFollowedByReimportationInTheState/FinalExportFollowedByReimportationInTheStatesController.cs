using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class FinalExportFollowedByReimportationInTheStatesController
    : FinalExportFollowedByReimportationInTheStatesControllerBase
{
    public FinalExportFollowedByReimportationInTheStatesController(
        IFinalExportFollowedByReimportationInTheStatesService service
    )
        : base(service) { }
}
