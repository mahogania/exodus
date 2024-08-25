using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ShAnalyseCollectionTemporairesController : ShAnalyseCollectionTemporairesControllerBase
{
    public ShAnalyseCollectionTemporairesController(IShAnalyseCollectionTemporairesService service)
        : base(service) { }
}
