using Control.Infrastructure;

namespace Control.APIs;

public class DetailsOfGoodsForPassivePerfectionsService
    : DetailsOfGoodsForPassivePerfectionsServiceBase
{
    public DetailsOfGoodsForPassivePerfectionsService(ControlDbContext context)
        : base(context) { }
}
