using Code.Infrastructure;

namespace Code.APIs;

public class ShAnalyseCollectionTemporairesService : ShAnalyseCollectionTemporairesServiceBase
{
    public ShAnalyseCollectionTemporairesService(CodeDbContext context)
        : base(context) { }
}
