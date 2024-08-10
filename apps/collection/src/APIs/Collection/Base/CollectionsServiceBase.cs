using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class CollectionsServiceBase : ICollectionsService
{
    protected readonly CollectionDbContext _context;

    public CollectionsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one COLLECTION
    /// </summary>
    public async Task<Collection> CreateCollection(CollectionCreateInput createDto)
    {
        var collection = new CollectionDbModel
        {
            AttachmentFileId = createDto.AttachmentFileId,
            CollectedAmount = createDto.CollectedAmount,
            CollectionBankCode = createDto.CollectionBankCode,
            CollectionNo = createDto.CollectionNo,
            CollectionTypeCode = createDto.CollectionTypeCode,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            ExpenseCertificateNo = createDto.ExpenseCertificateNo,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            ManualRegistrationReasonContent = createDto.ManualRegistrationReasonContent,
            NoticeNo = createDto.NoticeNo,
            OfficeCode = createDto.OfficeCode,
            PaymentDate = createDto.PaymentDate,
            RegisteringPersonId = createDto.RegisteringPersonId,
            RegistrationDate = createDto.RegistrationDate,
            RegistrationSystemCategoryCode = createDto.RegistrationSystemCategoryCode,
            ServiceCode = createDto.ServiceCode,
            TaxpayerPhoneNo = createDto.TaxpayerPhoneNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) collection.Id = createDto.Id;

        _context.Collections.Add(collection);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CollectionDbModel>(collection.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one COLLECTION
    /// </summary>
    public async Task DeleteCollection(CollectionWhereUniqueInput uniqueId)
    {
        var collection = await _context.Collections.FindAsync(uniqueId.Id);
        if (collection == null) throw new NotFoundException();

        _context.Collections.Remove(collection);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many COLLECTIONS
    /// </summary>
    public async Task<List<Collection>> Collections(CollectionFindManyArgs findManyArgs)
    {
        var collections = await _context
            .Collections.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return collections.ConvertAll(collection => collection.ToDto());
    }

    /// <summary>
    ///     Meta data about COLLECTION records
    /// </summary>
    public async Task<MetadataDto> CollectionsMeta(CollectionFindManyArgs findManyArgs)
    {
        var count = await _context.Collections.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one COLLECTION
    /// </summary>
    public async Task<Collection> Collection(CollectionWhereUniqueInput uniqueId)
    {
        var collections = await Collections(
            new CollectionFindManyArgs { Where = new CollectionWhereInput { Id = uniqueId.Id } }
        );
        var collection = collections.FirstOrDefault();
        if (collection == null) throw new NotFoundException();

        return collection;
    }

    /// <summary>
    ///     Update one COLLECTION
    /// </summary>
    public async Task UpdateCollection(
        CollectionWhereUniqueInput uniqueId,
        CollectionUpdateInput updateDto
    )
    {
        var collection = updateDto.ToModel(uniqueId);

        _context.Entry(collection).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Collections.Any(e => e.Id == collection.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
