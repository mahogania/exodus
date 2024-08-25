using Control.Infrastructure;

namespace Control.APIs;

public class TaxForVerificationsService : TaxForVerificationsServiceBase
{
    public TaxForVerificationsService(ControlDbContext context)
        : base(context) { }
}
