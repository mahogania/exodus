using Clre.Infrastructure;

namespace Clre.APIs;

public class StateOfGoodsForPassivePerfectionCommonsService
    : StateOfGoodsForPassivePerfectionCommonsServiceBase
{
    public StateOfGoodsForPassivePerfectionCommonsService(ClreDbContext context)
        : base(context) { }
}
