using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class InformationOfGoodsAtAndStandardExchangesController
    : InformationOfGoodsAtAndStandardExchangesControllerBase
{
    public InformationOfGoodsAtAndStandardExchangesController(
        IInformationOfGoodsAtAndStandardExchangesService service
    )
        : base(service) { }
}
