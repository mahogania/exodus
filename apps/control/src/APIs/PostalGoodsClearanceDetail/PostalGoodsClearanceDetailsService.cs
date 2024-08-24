using Control.Infrastructure;

namespace Control.APIs;

public class PostalGoodsClearanceDetailsService : PostalGoodsClearanceDetailsServiceBase
{
    public PostalGoodsClearanceDetailsService(ControlDbContext context)
        : base(context) { }
}
