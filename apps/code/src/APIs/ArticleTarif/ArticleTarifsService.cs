using Code.Infrastructure;

namespace Code.APIs;

public class ArticleTarifsService : ArticleTarifsServiceBase
{
    public ArticleTarifsService(CodeDbContext context)
        : base(context) { }
}
