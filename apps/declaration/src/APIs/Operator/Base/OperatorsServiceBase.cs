using Statement.APIs;
using Statement.Infrastructure;
using Statement.APIs.Dtos;
using Statement.Infrastructure.Models;
using Statement.APIs.Errors;
using Statement.APIs.Extensions;
using Statement.APIs.Common;
using Microsoft.EntityFrameworkCore;

namespace Statement.APIs;

public abstract class OperatorsServiceBase : IOperatorsService
{
    protected readonly StatementDbContext _context;
    public OperatorsServiceBase(StatementDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Operator
    /// </summary>
    public async Task<Operator> CreateOperator(OperatorCreateInput createDto)
    {
        var operator = new OperatorDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DcerAddr = createDto.DcerAddr,
            DcerCoNm = createDto.DcerCoNm,
            DelOn = createDto.DelOn,
            ExppnAddr = createDto.ExppnAddr,
            ExppnCoNm = createDto.ExppnCoNm,
            ExppnEml = createDto.ExppnEml,
            FrstRegstId = createDto.FrstRegstId,
            FrstRgsrDttm = createDto.FrstRgsrDttm,
            ImppnAddr = createDto.ImppnAddr,
            ImppnCoNm = createDto.ImppnCoNm,
            LastChgDttm = createDto.LastChgDttm,
            LastChprId = createDto.LastChprId,
            MdfyDgcnt = createDto.MdfyDgcnt,
            ReffNo = createDto.ReffNo,
            TxprAddr = createDto.TxprAddr,
            TxprCoNm = createDto.TxprCoNm,
            TxprEml = createDto.TxprEml,
            TxprTlphNo = createDto.TxprTlphNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
              operator.Id = createDto.Id;
        }


        _context.Operators.Add(operator);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<OperatorDbModel>(operator.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Operator
    /// </summary>
    public async Task DeleteOperator(OperatorWhereUniqueInput uniqueId)
    {
        var operator = await _context.Operators.FindAsync(uniqueId.Id);
        if (operator == null)
        {
            throw new NotFoundException();
        }

        _context.Operators.Remove(operator);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Operators
    /// </summary>
    public async Task<List<Operator>> Operators(OperatorFindManyArgs findManyArgs)
    {
        var operators = await _context
              .Operators

      .ApplyWhere(findManyArgs.Where)
      .ApplySkip(findManyArgs.Skip)
      .ApplyTake(findManyArgs.Take)
      .ApplyOrderBy(findManyArgs.SortBy)
      .ToListAsync();
        return operators.ConvertAll(operator => operator.ToDto());
    }

    /// <summary>
    /// Meta data about Operator records
    /// </summary>
    public async Task<MetadataDto> OperatorsMeta(OperatorFindManyArgs findManyArgs)
    {

        var count = await _context
    .Operators
    .ApplyWhere(findManyArgs.Where)
    .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Operator
    /// </summary>
    public async Task<Operator> Operator(OperatorWhereUniqueInput uniqueId)
    {
        var operators = await this.Operators(
                  new OperatorFindManyArgs { Where = new OperatorWhereInput { Id = uniqueId.Id } }
      );
        var operator = operators.FirstOrDefault();
        if (operator == null)
      {
            throw new NotFoundException();
        }

        return operator;
    }

    /// <summary>
    /// Update one Operator
    /// </summary>
    public async Task UpdateOperator(OperatorWhereUniqueInput uniqueId, OperatorUpdateInput updateDto)
    {
        var operator = updateDto.ToModel(uniqueId);



        _context.Entry(operator).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Operators.Any(e => e.Id == operator.Id))
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
