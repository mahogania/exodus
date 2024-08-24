using Control.Infrastructure;

namespace Control.APIs;

public class ArticlesService : ArticlesServiceBase
{
    public ArticlesService(ControlDbContext context)
        : base(context) { }
}
