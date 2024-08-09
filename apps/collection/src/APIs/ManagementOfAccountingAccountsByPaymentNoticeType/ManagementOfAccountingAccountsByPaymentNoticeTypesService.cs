using Collection.Infrastructure;

namespace Collection.APIs;

public class ManagementOfAccountingAccountsByPaymentNoticeTypesService
    : ManagementOfAccountingAccountsByPaymentNoticeTypesServiceBase
{
    public ManagementOfAccountingAccountsByPaymentNoticeTypesService(CollectionDbContext context)
        : base(context) { }
}
