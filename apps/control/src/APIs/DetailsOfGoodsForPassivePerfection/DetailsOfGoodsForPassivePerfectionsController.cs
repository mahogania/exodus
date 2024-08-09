using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class DetailsOfGoodsForPassivePerfectionsController
    : DetailsOfGoodsForPassivePerfectionsControllerBase
{
    public DetailsOfGoodsForPassivePerfectionsController(
        IDetailsOfGoodsForPassivePerfectionsService service
    )
        : base(service) { }
}
