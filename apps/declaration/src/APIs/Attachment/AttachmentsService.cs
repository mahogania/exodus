using Statement.Infrastructure;

namespace Statement.APIs;

public class AttachmentsService : AttachmentsServiceBase
{
    public AttachmentsService(StatementDbContext context)
        : base(context) { }
}
