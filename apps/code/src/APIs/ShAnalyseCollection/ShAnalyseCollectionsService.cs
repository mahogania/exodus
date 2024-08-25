using Code.Infrastructure;

namespace Code.APIs;

public class ShAnalyseCollectionsService : ShAnalyseCollectionsServiceBase
{
    public ShAnalyseCollectionsService(CodeDbContext context)
        : base(context) { }
}
