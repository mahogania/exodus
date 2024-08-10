using Control.Infrastructure;

namespace Control.APIs;

public class CustomsDeclarationBondsService : CustomsDeclarationBondsServiceBase
{
    public CustomsDeclarationBondsService(ControlDbContext context)
        : base(context)
    {
    }
}
