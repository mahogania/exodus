using Clre.Infrastructure;

namespace Clre.APIs;

public class RequestForTirCarnetOfTheArticlesService : RequestForTirCarnetOfTheArticlesServiceBase
{
    public RequestForTirCarnetOfTheArticlesService(ClreDbContext context)
        : base(context) { }
}
