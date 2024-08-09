using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class InformationOfGoodsAtAndStandardExchangesController
    : InformationOfGoodsAtAndStandardExchangesControllerBase
{
    public InformationOfGoodsAtAndStandardExchangesController(
        IInformationOfGoodsAtAndStandardExchangesService service
    )
        : base(service) { }
}
