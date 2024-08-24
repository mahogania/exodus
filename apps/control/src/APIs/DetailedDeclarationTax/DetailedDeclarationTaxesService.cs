using Control.Infrastructure;

namespace Control.APIs;

public class DetailedDeclarationTaxesService : DetailedDeclarationTaxesServiceBase
{
    public DetailedDeclarationTaxesService(ControlDbContext context)
        : base(context) { }
}
