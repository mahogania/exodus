using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ShAnalyseCollectionEntreprisesController : ShAnalyseCollectionEntreprisesControllerBase
{
    public ShAnalyseCollectionEntreprisesController(IShAnalyseCollectionEntreprisesService service)
        : base(service) { }
}
