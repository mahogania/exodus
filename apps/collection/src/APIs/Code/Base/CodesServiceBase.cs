using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class CodesServiceBase : ICodesService
{
    protected readonly CollectionDbContext _context;

    public CodesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one CODE
    /// </summary>
    public async Task<Code> CreateCode(CodeCreateInput createDto)
    {
        var code = new CodeDbModel
        {
            CappedAmount = createDto.CappedAmount,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FineRelatedTaxCode = createDto.FineRelatedTaxCode,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            FloorAmount = createDto.FloorAmount,
            InfractionCode = createDto.InfractionCode,
            InfractionCodeDescription = createDto.InfractionCodeDescription,
            InfractionCodeDetails = createDto.InfractionCodeDetails,
            InfractionCodeLabel = createDto.InfractionCodeLabel,
            OperationTypeCode = createDto.OperationTypeCode,
            UpdatedAt = createDto.UpdatedAt,
            UsedOn = createDto.UsedOn
        };

        if (createDto.Id != null)
        {
            code.Id = createDto.Id;
        }

        _context.Codes.Add(code);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CodeDbModel>(code.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one CODE
    /// </summary>
    public async Task DeleteCode(CodeWhereUniqueInput uniqueId)
    {
        var code = await _context.Codes.FindAsync(uniqueId.Id);
        if (code == null)
        {
            throw new NotFoundException();
        }

        _context.Codes.Remove(code);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many CODES
    /// </summary>
    public async Task<List<Code>> Codes(CodeFindManyArgs findManyArgs)
    {
        var codes = await _context
            .Codes.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return codes.ConvertAll(code => code.ToDto());
    }

    /// <summary>
    /// Meta data about CODE records
    /// </summary>
    public async Task<MetadataDto> CodesMeta(CodeFindManyArgs findManyArgs)
    {
        var count = await _context.Codes.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one CODE
    /// </summary>
    public async Task<Code> Code(CodeWhereUniqueInput uniqueId)
    {
        var codes = await this.Codes(
            new CodeFindManyArgs { Where = new CodeWhereInput { Id = uniqueId.Id } }
        );
        var code = codes.FirstOrDefault();
        if (code == null)
        {
            throw new NotFoundException();
        }

        return code;
    }

    /// <summary>
    /// Update one CODE
    /// </summary>
    public async Task UpdateCode(CodeWhereUniqueInput uniqueId, CodeUpdateInput updateDto)
    {
        var code = updateDto.ToModel(uniqueId);

        _context.Entry(code).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Codes.Any(e => e.Id == code.Id))
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
