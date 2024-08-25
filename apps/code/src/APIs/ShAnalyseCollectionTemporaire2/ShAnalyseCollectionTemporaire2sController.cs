using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ShAnalyseCollectionTemporaire2sController
    : ShAnalyseCollectionTemporaire2sControllerBase
{
    public ShAnalyseCollectionTemporaire2sController(
        IShAnalyseCollectionTemporaire2sService service
    )
        : base(service) { }
}
