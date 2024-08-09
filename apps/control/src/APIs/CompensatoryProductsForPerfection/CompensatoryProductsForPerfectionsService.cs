using Clre.Infrastructure;

namespace Clre.APIs;

public class CompensatoryProductsForPerfectionsService
    : CompensatoryProductsForPerfectionsServiceBase
{
    public CompensatoryProductsForPerfectionsService(ClreDbContext context)
        : base(context) { }
}
