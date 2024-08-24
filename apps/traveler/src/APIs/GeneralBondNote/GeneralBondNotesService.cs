using Traveler.Infrastructure;

namespace Traveler.APIs;

public class GeneralBondNotesService : GeneralBondNotesServiceBase
{
    public GeneralBondNotesService(TravelerDbContext context)
        : base(context) { }
}
