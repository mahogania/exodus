using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class DetailsOfAtGoodsForActivePerfectingsController
    : DetailsOfAtGoodsForActivePerfectingsControllerBase
{
    public DetailsOfAtGoodsForActivePerfectingsController(
        IDetailsOfAtGoodsForActivePerfectingsService service
    )
        : base(service) { }
}
