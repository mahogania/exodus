using Code.Infrastructure;

namespace Code.APIs;

public class ShAnalyseEvolutionPrixCollectionsService : ShAnalyseEvolutionPrixCollectionsServiceBase
{
    public ShAnalyseEvolutionPrixCollectionsService(CodeDbContext context)
        : base(context) { }
}
