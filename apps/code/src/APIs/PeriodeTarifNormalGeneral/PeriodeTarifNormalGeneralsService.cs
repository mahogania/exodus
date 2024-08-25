using Code.Infrastructure;

namespace Code.APIs;

public class PeriodeTarifNormalGeneralsService : PeriodeTarifNormalGeneralsServiceBase
{
    public PeriodeTarifNormalGeneralsService(CodeDbContext context)
        : base(context) { }
}
