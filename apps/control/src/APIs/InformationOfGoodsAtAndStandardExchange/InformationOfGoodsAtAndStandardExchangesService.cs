using Control.Infrastructure;

namespace Control.APIs;

public class InformationOfGoodsAtAndStandardExchangesService
    : InformationOfGoodsAtAndStandardExchangesServiceBase
{
    public InformationOfGoodsAtAndStandardExchangesService(ControlDbContext context)
        : base(context) { }
}
