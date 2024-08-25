using Code.Infrastructure;

namespace Code.APIs;

public class ShAnalyseCollectionEntreprisesService : ShAnalyseCollectionEntreprisesServiceBase
{
    public ShAnalyseCollectionEntreprisesService(CodeDbContext context)
        : base(context) { }
}
