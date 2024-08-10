using Control.Infrastructure;

namespace Control.APIs;

public class CustomsDetailedDeclarationTaxesService : CustomsDetailedDeclarationTaxesServiceBase
{
    public CustomsDetailedDeclarationTaxesService(ControlDbContext context)
        : base(context)
    {
    }
}
