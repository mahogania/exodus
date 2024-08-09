using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class DetailsOfGoodsForPassivePerfectionsController
    : DetailsOfGoodsForPassivePerfectionsControllerBase
{
    public DetailsOfGoodsForPassivePerfectionsController(
        IDetailsOfGoodsForPassivePerfectionsService service
    )
        : base(service) { }
}
