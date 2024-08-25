using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ShAnalyseCollectionTemporaire3sController
    : ShAnalyseCollectionTemporaire3sControllerBase
{
    public ShAnalyseCollectionTemporaire3sController(
        IShAnalyseCollectionTemporaire3sService service
    )
        : base(service) { }
}
