using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class AccountingsServiceBase : IAccountingsService
{
    protected readonly CollectionDbContext _context;

    public AccountingsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ACCOUNTING
    /// </summary>
    public async Task<Accounting> CreateAccounting(AccountingCreateInput createDto)
    {
        var accounting = new AccountingDbModel
        {
            ApprovalId = createDto.ApprovalId,
            AttachmentId = createDto.AttachmentId,
            ContainerSize = createDto.ContainerSize,
            CreatedAt = createDto.CreatedAt,
            Crn = createDto.Crn,
            CustomsAreaCode = createDto.CustomsAreaCode,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FinalUseCode = createDto.FinalUseCode,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            HandlingDate = createDto.HandlingDate,
            ItemName = createDto.ItemName,
            NumberOfPackages = createDto.NumberOfPackages,
            OfficeCode = createDto.OfficeCode,
            ReferenceFileRegistrationDate = createDto.ReferenceFileRegistrationDate,
            ReferenceNo = createDto.ReferenceNo,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = createDto.ReferenceNumberTypeName,
            ServiceCode = createDto.ServiceCode,
            StockAccountingManagementNumber = createDto.StockAccountingManagementNumber,
            Storage = createDto.Storage,
            UpdatedAt = createDto.UpdatedAt,
            Weight = createDto.Weight
        };

        if (createDto.Id != null)
        {
            accounting.Id = createDto.Id;
        }

        _context.Accountings.Add(accounting);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<AccountingDbModel>(accounting.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ACCOUNTING
    /// </summary>
    public async Task DeleteAccounting(AccountingWhereUniqueInput uniqueId)
    {
        var accounting = await _context.Accountings.FindAsync(uniqueId.Id);
        if (accounting == null)
        {
            throw new NotFoundException();
        }

        _context.Accountings.Remove(accounting);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ACCOUNTINGS
    /// </summary>
    public async Task<List<Accounting>> Accountings(AccountingFindManyArgs findManyArgs)
    {
        var accountings = await _context
            .Accountings.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return accountings.ConvertAll(accounting => accounting.ToDto());
    }

    /// <summary>
    /// Meta data about ACCOUNTING records
    /// </summary>
    public async Task<MetadataDto> AccountingsMeta(AccountingFindManyArgs findManyArgs)
    {
        var count = await _context.Accountings.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ACCOUNTING
    /// </summary>
    public async Task<Accounting> Accounting(AccountingWhereUniqueInput uniqueId)
    {
        var accountings = await this.Accountings(
            new AccountingFindManyArgs { Where = new AccountingWhereInput { Id = uniqueId.Id } }
        );
        var accounting = accountings.FirstOrDefault();
        if (accounting == null)
        {
            throw new NotFoundException();
        }

        return accounting;
    }

    /// <summary>
    /// Update one ACCOUNTING
    /// </summary>
    public async Task UpdateAccounting(
        AccountingWhereUniqueInput uniqueId,
        AccountingUpdateInput updateDto
    )
    {
        var accounting = updateDto.ToModel(uniqueId);

        _context.Entry(accounting).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Accountings.Any(e => e.Id == accounting.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }
}
