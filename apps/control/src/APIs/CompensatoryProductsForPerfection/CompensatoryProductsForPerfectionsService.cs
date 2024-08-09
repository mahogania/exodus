using Control.Infrastructure;

namespace Control.APIs;

public class CompensatoryProductsForPerfectionsService
    : CompensatoryProductsForPerfectionsServiceBase
{
    public CompensatoryProductsForPerfectionsService(ControlDbContext context)
        : base(context) { }
}
