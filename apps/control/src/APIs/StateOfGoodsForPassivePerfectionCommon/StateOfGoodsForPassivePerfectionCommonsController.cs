using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class StateOfGoodsForPassivePerfectionCommonsController
    : StateOfGoodsForPassivePerfectionCommonsControllerBase
{
    public StateOfGoodsForPassivePerfectionCommonsController(
        IStateOfGoodsForPassivePerfectionCommonsService service
    )
        : base(service) { }
}
