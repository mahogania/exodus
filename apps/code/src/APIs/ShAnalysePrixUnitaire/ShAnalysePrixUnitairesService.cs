using Code.Infrastructure;

namespace Code.APIs;

public class ShAnalysePrixUnitairesService : ShAnalysePrixUnitairesServiceBase
{
    public ShAnalysePrixUnitairesService(CodeDbContext context)
        : base(context) { }
}
