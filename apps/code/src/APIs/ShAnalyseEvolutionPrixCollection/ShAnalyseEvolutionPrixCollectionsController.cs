using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ShAnalyseEvolutionPrixCollectionsController
    : ShAnalyseEvolutionPrixCollectionsControllerBase
{
    public ShAnalyseEvolutionPrixCollectionsController(
        IShAnalyseEvolutionPrixCollectionsService service
    )
        : base(service) { }
}
