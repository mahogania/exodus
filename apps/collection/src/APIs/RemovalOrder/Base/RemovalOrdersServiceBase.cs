using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class RemovalOrdersServiceBase : IRemovalOrdersService
{
    protected readonly CollectionDbContext _context;

    public RemovalOrdersServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one REMOVAL ORDER
    /// </summary>
    public async Task<RemovalOrder> CreateRemovalOrder(RemovalOrderCreateInput createDto)
    {
        var removalOrder = new RemovalOrderDbModel
        {
            ArticlePackageQuantity = createDto.ArticlePackageQuantity,
            ArticlePackageUnitCode = createDto.ArticlePackageUnitCode,
            AttachedFileId = createDto.AttachedFileId,
            CreatedAt = createDto.CreatedAt,
            Crn = createDto.Crn,
            CustomsZoneCode = createDto.CustomsZoneCode,
            DeclarantCode = createDto.DeclarantCode,
            DeclarantName = createDto.DeclarantName,
            DeletionFlag = createDto.DeletionFlag,
            ExporterIdentificationNumber = createDto.ExporterIdentificationNumber,
            ExporterIdentificationNumberTypeCode = createDto.ExporterIdentificationNumberTypeCode,
            ExporterName = createDto.ExporterName,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            Forwarder = createDto.Forwarder,
            ImporterIdentificationNumber = createDto.ImporterIdentificationNumber,
            ImporterIdentificationNumberTypeCode = createDto.ImporterIdentificationNumberTypeCode,
            ImporterName = createDto.ImporterName,
            NoticeNumber = createDto.NoticeNumber,
            NumberOfTimesRemovalOrderPrinted = createDto.NumberOfTimesRemovalOrderPrinted,
            OfficeCode = createDto.OfficeCode,
            PaymentDate = createDto.PaymentDate,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            ReceiptNumber = createDto.ReceiptNumber,
            ReferenceDate = createDto.ReferenceDate,
            ReferenceNumber = createDto.ReferenceNumber,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            RegistrationDate = createDto.RegistrationDate,
            RemarksContent = createDto.RemarksContent,
            RemovalOrderNumber = createDto.RemovalOrderNumber,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            removalOrder.Id = createDto.Id;
        }

        _context.RemovalOrders.Add(removalOrder);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RemovalOrderDbModel>(removalOrder.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one REMOVAL ORDER
    /// </summary>
    public async Task DeleteRemovalOrder(RemovalOrderWhereUniqueInput uniqueId)
    {
        var removalOrder = await _context.RemovalOrders.FindAsync(uniqueId.Id);
        if (removalOrder == null)
        {
            throw new NotFoundException();
        }

        _context.RemovalOrders.Remove(removalOrder);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many REMOVAL ORDERS
    /// </summary>
    public async Task<List<RemovalOrder>> RemovalOrders(RemovalOrderFindManyArgs findManyArgs)
    {
        var removalOrders = await _context
            .RemovalOrders.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return removalOrders.ConvertAll(removalOrder => removalOrder.ToDto());
    }

    /// <summary>
    /// Meta data about REMOVAL ORDER records
    /// </summary>
    public async Task<MetadataDto> RemovalOrdersMeta(RemovalOrderFindManyArgs findManyArgs)
    {
        var count = await _context.RemovalOrders.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one REMOVAL ORDER
    /// </summary>
    public async Task<RemovalOrder> RemovalOrder(RemovalOrderWhereUniqueInput uniqueId)
    {
        var removalOrders = await this.RemovalOrders(
            new RemovalOrderFindManyArgs { Where = new RemovalOrderWhereInput { Id = uniqueId.Id } }
        );
        var removalOrder = removalOrders.FirstOrDefault();
        if (removalOrder == null)
        {
            throw new NotFoundException();
        }

        return removalOrder;
    }

    /// <summary>
    /// Update one REMOVAL ORDER
    /// </summary>
    public async Task UpdateRemovalOrder(
        RemovalOrderWhereUniqueInput uniqueId,
        RemovalOrderUpdateInput updateDto
    )
    {
        var removalOrder = updateDto.ToModel(uniqueId);

        _context.Entry(removalOrder).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.RemovalOrders.Any(e => e.Id == removalOrder.Id))
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
