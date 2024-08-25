using Code.Infrastructure;

namespace Code.APIs;

public class ValeurBoursieresService : ValeurBoursieresServiceBase
{
    public ValeurBoursieresService(CodeDbContext context)
        : base(context) { }
}
