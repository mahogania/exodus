using Control.Infrastructure;

namespace Control.APIs;

public class ArticlesSubmittedForVerificationsService : ArticlesSubmittedForVerificationsServiceBase
{
    public ArticlesSubmittedForVerificationsService(ControlDbContext context)
        : base(context) { }
}
