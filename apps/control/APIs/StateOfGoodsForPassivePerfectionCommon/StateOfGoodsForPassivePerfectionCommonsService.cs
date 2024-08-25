using Control.Infrastructure;

namespace Control.APIs;

public class StateOfGoodsForPassivePerfectionCommonsService
    : StateOfGoodsForPassivePerfectionCommonsServiceBase
{
    public StateOfGoodsForPassivePerfectionCommonsService(ControlDbContext context)
        : base(context)
    {
    }
}
