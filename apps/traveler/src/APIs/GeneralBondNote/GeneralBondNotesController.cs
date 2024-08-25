using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class GeneralBondNotesController : GeneralBondNotesControllerBase
{
    public GeneralBondNotesController(IGeneralBondNotesService service)
        : base(service) { }
}
