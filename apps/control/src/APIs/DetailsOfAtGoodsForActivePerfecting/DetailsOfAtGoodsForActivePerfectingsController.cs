using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class DetailsOfAtGoodsForActivePerfectingsController
    : DetailsOfAtGoodsForActivePerfectingsControllerBase
{
    public DetailsOfAtGoodsForActivePerfectingsController(
        IDetailsOfAtGoodsForActivePerfectingsService service
    )
        : base(service) { }
}
