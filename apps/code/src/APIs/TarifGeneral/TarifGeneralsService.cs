using Code.Infrastructure;

namespace Code.APIs;

public class TarifGeneralsService : TarifGeneralsServiceBase
{
    public TarifGeneralsService(CodeDbContext context)
        : base(context) { }
}
