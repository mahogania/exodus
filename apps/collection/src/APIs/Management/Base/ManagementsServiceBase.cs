using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class ManagementsServiceBase : IManagementsService
{
    protected readonly CollectionDbContext _context;

    public ManagementsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one MANAGEMENT
    /// </summary>
    public async Task<Management> CreateManagement(ManagementCreateInput createDto)
    {
        var management = new ManagementDbModel
        {
            AccountCode = createDto.AccountCode,
            AccountingServiceCode = createDto.AccountingServiceCode,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            ErrorDate = createDto.ErrorDate,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            OfficeCode = createDto.OfficeCode,
            OperationReason = createDto.OperationReason,
            OrderOperationNumber = createDto.OrderOperationNumber,
            ReferenceFileRegistrationDate = createDto.ReferenceFileRegistrationDate,
            ReferenceNo = createDto.ReferenceNo,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt,
            WriterServiceCode = createDto.WriterServiceCode
        };

        if (createDto.Id != null) management.Id = createDto.Id;

        _context.Managements.Add(management);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ManagementDbModel>(management.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one MANAGEMENT
    /// </summary>
    public async Task DeleteManagement(ManagementWhereUniqueInput uniqueId)
    {
        var management = await _context.Managements.FindAsync(uniqueId.Id);
        if (management == null) throw new NotFoundException();

        _context.Managements.Remove(management);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many MANAGEMENTS
    /// </summary>
    public async Task<List<Management>> Managements(ManagementFindManyArgs findManyArgs)
    {
        var managements = await _context
            .Managements.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return managements.ConvertAll(management => management.ToDto());
    }

    /// <summary>
    ///     Meta data about MANAGEMENT records
    /// </summary>
    public async Task<MetadataDto> ManagementsMeta(ManagementFindManyArgs findManyArgs)
    {
        var count = await _context.Managements.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one MANAGEMENT
    /// </summary>
    public async Task<Management> Management(ManagementWhereUniqueInput uniqueId)
    {
        var managements = await Managements(
            new ManagementFindManyArgs { Where = new ManagementWhereInput { Id = uniqueId.Id } }
        );
        var management = managements.FirstOrDefault();
        if (management == null) throw new NotFoundException();

        return management;
    }

    /// <summary>
    ///     Update one MANAGEMENT
    /// </summary>
    public async Task UpdateManagement(
        ManagementWhereUniqueInput uniqueId,
        ManagementUpdateInput updateDto
    )
    {
        var management = updateDto.ToModel(uniqueId);

        _context.Entry(management).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Managements.Any(e => e.Id == management.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
