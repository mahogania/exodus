using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IManagementOfAccountingAccountsByPaymentNoticeTypesService
{
    /// <summary>
    /// Create one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    public Task<ManagementOfAccountingAccountsByPaymentNoticeType> CreateManagementOfAccountingAccountsByPaymentNoticeType(
        ManagementOfAccountingAccountsByPaymentNoticeTypeCreateInput managementofaccountingaccountsbypaymentnoticetype
    );

    /// <summary>
    /// Delete one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    public Task DeleteManagementOfAccountingAccountsByPaymentNoticeType(
        ManagementOfAccountingAccountsByPaymentNoticeTypeWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPES
    /// </summary>
    public Task<
        List<ManagementOfAccountingAccountsByPaymentNoticeType>
    > ManagementOfAccountingAccountsByPaymentNoticeTypes(
        ManagementOfAccountingAccountsByPaymentNoticeTypeFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE records
    /// </summary>
    public Task<MetadataDto> ManagementOfAccountingAccountsByPaymentNoticeTypesMeta(
        ManagementOfAccountingAccountsByPaymentNoticeTypeFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    public Task<ManagementOfAccountingAccountsByPaymentNoticeType> ManagementOfAccountingAccountsByPaymentNoticeType(
        ManagementOfAccountingAccountsByPaymentNoticeTypeWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    public Task UpdateManagementOfAccountingAccountsByPaymentNoticeType(
        ManagementOfAccountingAccountsByPaymentNoticeTypeWhereUniqueInput uniqueId,
        ManagementOfAccountingAccountsByPaymentNoticeTypeUpdateInput updateDto
    );
}
