using Control.Infrastructure;

namespace Control.APIs;

public class InformationOfGoodsTransferredInWarehousePublicPrivatesService
    : InformationOfGoodsTransferredInWarehousePublicPrivatesServiceBase
{
    public InformationOfGoodsTransferredInWarehousePublicPrivatesService(ControlDbContext context)
        : base(context)
    {
    }
}
