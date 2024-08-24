using Control.Infrastructure;

namespace Control.APIs;

public class ArticleCarnetRequestsService : ArticleCarnetRequestsServiceBase
{
    public ArticleCarnetRequestsService(ControlDbContext context)
        : base(context) { }
}
