using Control.Infrastructure;

namespace Control.APIs;

public class RequestForCancellationOfTheDetailedDeclarationCustomsItemsService
    : RequestForCancellationOfTheDetailedDeclarationCustomsItemsServiceBase
{
    public RequestForCancellationOfTheDetailedDeclarationCustomsItemsService(
        ControlDbContext context
    )
        : base(context)
    {
    }
}
