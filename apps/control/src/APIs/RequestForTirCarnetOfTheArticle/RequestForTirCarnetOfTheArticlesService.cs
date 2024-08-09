using Control.Infrastructure;

namespace Control.APIs;

public class RequestForTirCarnetOfTheArticlesService : RequestForTirCarnetOfTheArticlesServiceBase
{
    public RequestForTirCarnetOfTheArticlesService(ControlDbContext context)
        : base(context) { }
}
