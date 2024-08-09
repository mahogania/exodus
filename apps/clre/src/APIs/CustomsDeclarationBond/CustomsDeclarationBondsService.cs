using Clre.Infrastructure;

namespace Clre.APIs;

public class CustomsDeclarationBondsService : CustomsDeclarationBondsServiceBase
{
    public CustomsDeclarationBondsService(ClreDbContext context)
        : base(context) { }
}
