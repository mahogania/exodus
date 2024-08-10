using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class ManageRecklessBiddersServiceBase : IManageRecklessBiddersService
{
    protected readonly CollectionDbContext _context;

    public ManageRecklessBiddersServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one MANAGE RECKLESS BIDDER
    /// </summary>
    public async Task<ManageRecklessBidder> CreateManageRecklessBidder(
        ManageRecklessBidderCreateInput createDto
    )
    {
        var manageRecklessBidder = new ManageRecklessBidderDbModel
        {
            BidderIdentificationNo = createDto.BidderIdentificationNo,
            BidderIdentificationNoTypeCode = createDto.BidderIdentificationNoTypeCode,
            BidderName = createDto.BidderName,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            DetailSequenceNo = createDto.DetailSequenceNo,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            LotNo = createDto.LotNo,
            OfficeCode = createDto.OfficeCode,
            RegistrationPersonIdentifier = createDto.RegistrationPersonIdentifier,
            RemarkContent = createDto.RemarkContent,
            SalePvNo = createDto.SalePvNo,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) manageRecklessBidder.Id = createDto.Id;

        _context.ManageRecklessBidders.Add(manageRecklessBidder);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ManageRecklessBidderDbModel>(manageRecklessBidder.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one MANAGE RECKLESS BIDDER
    /// </summary>
    public async Task DeleteManageRecklessBidder(ManageRecklessBidderWhereUniqueInput uniqueId)
    {
        var manageRecklessBidder = await _context.ManageRecklessBidders.FindAsync(uniqueId.Id);
        if (manageRecklessBidder == null) throw new NotFoundException();

        _context.ManageRecklessBidders.Remove(manageRecklessBidder);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many MANAGE RECKLESS BIDDERS
    /// </summary>
    public async Task<List<ManageRecklessBidder>> ManageRecklessBidders(
        ManageRecklessBidderFindManyArgs findManyArgs
    )
    {
        var manageRecklessBidders = await _context
            .ManageRecklessBidders.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return manageRecklessBidders.ConvertAll(manageRecklessBidder =>
            manageRecklessBidder.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about MANAGE RECKLESS BIDDER records
    /// </summary>
    public async Task<MetadataDto> ManageRecklessBiddersMeta(
        ManageRecklessBidderFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ManageRecklessBidders.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one MANAGE RECKLESS BIDDER
    /// </summary>
    public async Task<ManageRecklessBidder> ManageRecklessBidder(
        ManageRecklessBidderWhereUniqueInput uniqueId
    )
    {
        var manageRecklessBidders = await ManageRecklessBidders(
            new ManageRecklessBidderFindManyArgs
            {
                Where = new ManageRecklessBidderWhereInput { Id = uniqueId.Id }
            }
        );
        var manageRecklessBidder = manageRecklessBidders.FirstOrDefault();
        if (manageRecklessBidder == null) throw new NotFoundException();

        return manageRecklessBidder;
    }

    /// <summary>
    ///     Update one MANAGE RECKLESS BIDDER
    /// </summary>
    public async Task UpdateManageRecklessBidder(
        ManageRecklessBidderWhereUniqueInput uniqueId,
        ManageRecklessBidderUpdateInput updateDto
    )
    {
        var manageRecklessBidder = updateDto.ToModel(uniqueId);

        _context.Entry(manageRecklessBidder).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ManageRecklessBidders.Any(e => e.Id == manageRecklessBidder.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
