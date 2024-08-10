using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class ManagementOfAccountingAccountsByPaymentNoticeTypesServiceBase
    : IManagementOfAccountingAccountsByPaymentNoticeTypesService
{
    protected readonly CollectionDbContext _context;

    public ManagementOfAccountingAccountsByPaymentNoticeTypesServiceBase(
        CollectionDbContext context
    )
    {
        _context = context;
    }

    /// <summary>
    ///     Create one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    public async Task<ManagementOfAccountingAccountsByPaymentNoticeType>
        CreateManagementOfAccountingAccountsByPaymentNoticeType(
            ManagementOfAccountingAccountsByPaymentNoticeTypeCreateInput createDto
        )
    {
        var managementOfAccountingAccountsByPaymentNoticeType =
            new ManagementOfAccountingAccountsByPaymentNoticeTypeDbModel
            {
                AccountCode = createDto.AccountCode,
                AlignmentOrder = createDto.AlignmentOrder,
                ApplicationStartDate = createDto.ApplicationStartDate,
                AuxiliaryJournalDesignation = createDto.AuxiliaryJournalDesignation,
                BalanceSheetCategoryCode = createDto.BalanceSheetCategoryCode,
                CreatedAt = createDto.CreatedAt,
                DeletionOn = createDto.DeletionOn,
                DetailSequenceNo = createDto.DetailSequenceNo,
                FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
                FinalModifierId = createDto.FinalModifierId,
                FirstRegistrantId = createDto.FirstRegistrantId,
                FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
                NoticeTypeCode = createDto.NoticeTypeCode,
                PartialOrParticularDistribution = createDto.PartialOrParticularDistribution,
                ReasonCodeByPaymentNoticeType = createDto.ReasonCodeByPaymentNoticeType,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null) managementOfAccountingAccountsByPaymentNoticeType.Id = createDto.Id;

        _context.ManagementOfAccountingAccountsByPaymentNoticeTypes.Add(
            managementOfAccountingAccountsByPaymentNoticeType
        );
        await _context.SaveChangesAsync();

        var result =
            await _context.FindAsync<ManagementOfAccountingAccountsByPaymentNoticeTypeDbModel>(
                managementOfAccountingAccountsByPaymentNoticeType.Id
            );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    public async Task DeleteManagementOfAccountingAccountsByPaymentNoticeType(
        ManagementOfAccountingAccountsByPaymentNoticeTypeWhereUniqueInput uniqueId
    )
    {
        var managementOfAccountingAccountsByPaymentNoticeType =
            await _context.ManagementOfAccountingAccountsByPaymentNoticeTypes.FindAsync(
                uniqueId.Id
            );
        if (managementOfAccountingAccountsByPaymentNoticeType == null) throw new NotFoundException();

        _context.ManagementOfAccountingAccountsByPaymentNoticeTypes.Remove(
            managementOfAccountingAccountsByPaymentNoticeType
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPES
    /// </summary>
    public async Task<
        List<ManagementOfAccountingAccountsByPaymentNoticeType>
    > ManagementOfAccountingAccountsByPaymentNoticeTypes(
        ManagementOfAccountingAccountsByPaymentNoticeTypeFindManyArgs findManyArgs
    )
    {
        var managementOfAccountingAccountsByPaymentNoticeTypes = await _context
            .ManagementOfAccountingAccountsByPaymentNoticeTypes.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return managementOfAccountingAccountsByPaymentNoticeTypes.ConvertAll(
            managementOfAccountingAccountsByPaymentNoticeType =>
                managementOfAccountingAccountsByPaymentNoticeType.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE records
    /// </summary>
    public async Task<MetadataDto> ManagementOfAccountingAccountsByPaymentNoticeTypesMeta(
        ManagementOfAccountingAccountsByPaymentNoticeTypeFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ManagementOfAccountingAccountsByPaymentNoticeTypes.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    public async Task<ManagementOfAccountingAccountsByPaymentNoticeType>
        ManagementOfAccountingAccountsByPaymentNoticeType(
            ManagementOfAccountingAccountsByPaymentNoticeTypeWhereUniqueInput uniqueId
        )
    {
        var managementOfAccountingAccountsByPaymentNoticeTypes =
            await ManagementOfAccountingAccountsByPaymentNoticeTypes(
                new ManagementOfAccountingAccountsByPaymentNoticeTypeFindManyArgs
                {
                    Where = new ManagementOfAccountingAccountsByPaymentNoticeTypeWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var managementOfAccountingAccountsByPaymentNoticeType =
            managementOfAccountingAccountsByPaymentNoticeTypes.FirstOrDefault();
        if (managementOfAccountingAccountsByPaymentNoticeType == null) throw new NotFoundException();

        return managementOfAccountingAccountsByPaymentNoticeType;
    }

    /// <summary>
    ///     Update one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    public async Task UpdateManagementOfAccountingAccountsByPaymentNoticeType(
        ManagementOfAccountingAccountsByPaymentNoticeTypeWhereUniqueInput uniqueId,
        ManagementOfAccountingAccountsByPaymentNoticeTypeUpdateInput updateDto
    )
    {
        var managementOfAccountingAccountsByPaymentNoticeType = updateDto.ToModel(uniqueId);

        _context.Entry(managementOfAccountingAccountsByPaymentNoticeType).State =
            EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ManagementOfAccountingAccountsByPaymentNoticeTypes.Any(e =>
                    e.Id == managementOfAccountingAccountsByPaymentNoticeType.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
