using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class InformationOfGoodsTransferredInWarehousePublicPrivatesController
    : InformationOfGoodsTransferredInWarehousePublicPrivatesControllerBase
{
    public InformationOfGoodsTransferredInWarehousePublicPrivatesController(
        IInformationOfGoodsTransferredInWarehousePublicPrivatesService service
    )
        : base(service)
    {
    }
}
