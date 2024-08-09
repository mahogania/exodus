using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class StateOfGoodsForPassivePerfectionCommonsController
    : StateOfGoodsForPassivePerfectionCommonsControllerBase
{
    public StateOfGoodsForPassivePerfectionCommonsController(
        IStateOfGoodsForPassivePerfectionCommonsService service
    )
        : base(service) { }
}
