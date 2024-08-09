using Clre.Infrastructure;

namespace Clre.APIs;

public class CustomsDetailedDeclarationTaxesService : CustomsDetailedDeclarationTaxesServiceBase
{
    public CustomsDetailedDeclarationTaxesService(ClreDbContext context)
        : base(context) { }
}
