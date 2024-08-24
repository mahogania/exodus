using Control.Infrastructure;

namespace Control.APIs;

public class ArticleAssessmentsService : ArticleAssessmentsServiceBase
{
    public ArticleAssessmentsService(ControlDbContext context)
        : base(context) { }
}
