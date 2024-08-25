using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class GeneralTravelerInformationTpdsController : GeneralTravelerInformationTpdsControllerBase
{
    public GeneralTravelerInformationTpdsController(IGeneralTravelerInformationTpdsService service)
        : base(service) { }
}
