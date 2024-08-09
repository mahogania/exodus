using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class ManagementOfAccountingAccountsByPaymentNoticeTypesController
    : ManagementOfAccountingAccountsByPaymentNoticeTypesControllerBase
{
    public ManagementOfAccountingAccountsByPaymentNoticeTypesController(
        IManagementOfAccountingAccountsByPaymentNoticeTypesService service
    )
        : base(service) { }
}
