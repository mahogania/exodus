using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class AccompaniedBaggageEntryAndExitsController
    : AccompaniedBaggageEntryAndExitsControllerBase
{
    public AccompaniedBaggageEntryAndExitsController(
        IAccompaniedBaggageEntryAndExitsService service
    )
        : base(service) { }
}
