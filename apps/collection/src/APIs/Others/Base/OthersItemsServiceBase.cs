using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class OthersItemsServiceBase : IOthersItemsService
{
    protected readonly CollectionDbContext _context;

    public OthersItemsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one OTHERS
    /// </summary>
    public async Task<Others> CreateOthers(OthersCreateInput createDto)
    {
        var others = new OthersDbModel
        {
            AmountOfOtherChargeableFees = createDto.AmountOfOtherChargeableFees,
            AttachmentId = createDto.AttachmentId,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FinancialManagerName = createDto.FinancialManagerName,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NiuCategoryCode = createDto.NiuCategoryCode,
            NiuCategoryName = createDto.NiuCategoryName,
            NoticeNo = createDto.NoticeNo,
            OfficeCode = createDto.OfficeCode,
            ReferenceNo = createDto.ReferenceNo,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = createDto.ReferenceNumberTypeName,
            RegistrationReasonContent = createDto.RegistrationReasonContent,
            ServiceCode = createDto.ServiceCode,
            TaxpayerIdentificationNo = createDto.TaxpayerIdentificationNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) others.Id = createDto.Id;

        _context.OthersItems.Add(others);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<OthersDbModel>(others.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one OTHERS
    /// </summary>
    public async Task DeleteOthers(OthersWhereUniqueInput uniqueId)
    {
        var others = await _context.OthersItems.FindAsync(uniqueId.Id);
        if (others == null) throw new NotFoundException();

        _context.OthersItems.Remove(others);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many OTHERSItems
    /// </summary>
    public async Task<List<Others>> OthersItems(OthersFindManyArgs findManyArgs)
    {
        var othersItems = await _context
            .OthersItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return othersItems.ConvertAll(others => others.ToDto());
    }

    /// <summary>
    ///     Meta data about OTHERS records
    /// </summary>
    public async Task<MetadataDto> OthersItemsMeta(OthersFindManyArgs findManyArgs)
    {
        var count = await _context.OthersItems.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one OTHERS
    /// </summary>
    public async Task<Others> Others(OthersWhereUniqueInput uniqueId)
    {
        var othersItems = await OthersItems(
            new OthersFindManyArgs { Where = new OthersWhereInput { Id = uniqueId.Id } }
        );
        var others = othersItems.FirstOrDefault();
        if (others == null) throw new NotFoundException();

        return others;
    }

    /// <summary>
    ///     Update one OTHERS
    /// </summary>
    public async Task UpdateOthers(OthersWhereUniqueInput uniqueId, OthersUpdateInput updateDto)
    {
        var others = updateDto.ToModel(uniqueId);

        _context.Entry(others).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.OthersItems.Any(e => e.Id == others.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
