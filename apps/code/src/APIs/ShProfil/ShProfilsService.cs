using Code.Infrastructure;

namespace Code.APIs;

public class ShProfilsService : ShProfilsServiceBase
{
    public ShProfilsService(CodeDbContext context)
        : base(context) { }
}
