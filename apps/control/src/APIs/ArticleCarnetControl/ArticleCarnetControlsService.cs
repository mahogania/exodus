using Control.Infrastructure;

namespace Control.APIs;

public class ArticleCarnetControlsService : ArticleCarnetControlsServiceBase
{
    public ArticleCarnetControlsService(ControlDbContext context)
        : base(context) { }
}
