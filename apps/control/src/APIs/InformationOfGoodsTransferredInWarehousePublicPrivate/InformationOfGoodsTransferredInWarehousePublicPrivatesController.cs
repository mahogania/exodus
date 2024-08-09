using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class InformationOfGoodsTransferredInWarehousePublicPrivatesController
    : InformationOfGoodsTransferredInWarehousePublicPrivatesControllerBase
{
    public InformationOfGoodsTransferredInWarehousePublicPrivatesController(
        IInformationOfGoodsTransferredInWarehousePublicPrivatesService service
    )
        : base(service) { }
}
