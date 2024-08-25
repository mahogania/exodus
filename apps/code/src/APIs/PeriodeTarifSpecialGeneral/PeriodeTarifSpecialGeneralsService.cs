using Code.Infrastructure;

namespace Code.APIs;

public class PeriodeTarifSpecialGeneralsService : PeriodeTarifSpecialGeneralsServiceBase
{
    public PeriodeTarifSpecialGeneralsService(CodeDbContext context)
        : base(context) { }
}
