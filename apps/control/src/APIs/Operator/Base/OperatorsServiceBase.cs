using Control.APIs;
using Control.Infrastructure;
using Control.APIs.Dtos;
using Control.Infrastructure.Models;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.APIs.Common;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class OperatorsServiceBase : IOperatorsService
{
    protected readonly ControlDbContext _context;
    public OperatorsServiceBase(ControlDbContext context)
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
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeclarantSAddress = createDto.DeclarantSAddress,
            DeletionOn = createDto.DeletionOn,
            ExporterSAddress = createDto.ExporterSAddress,
            ExporterSEmail = createDto.ExporterSEmail,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            ImporterSAddress = createDto.ImporterSAddress,
            NameOfTheDeclarantSCompany = createDto.NameOfTheDeclarantSCompany,
            NameOfTheExporterSCompany = createDto.NameOfTheExporterSCompany,
            NameOfTheImporterSCompany = createDto.NameOfTheImporterSCompany,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceNumber = createDto.ReferenceNumber,
            TaxpayerPhoneNumber = createDto.TaxpayerPhoneNumber,
            TaxpayerSAddress = createDto.TaxpayerSAddress,
            TaxpayerSCompanyName = createDto.TaxpayerSCompanyName,
            TaxpayerSEmail = createDto.TaxpayerSEmail,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
              operator.Id = createDto.Id;
        }
        if (createDto.CommonDetailedDeclaration != null)
        {
                operator.CommonDetailedDeclaration = await _context
                    .CommonDetailedDeclarations.Where(commonDetailedDeclaration => createDto.CommonDetailedDeclaration.Id == commonDetailedDeclaration.Id)
                    .FirstOrDefaultAsync();
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
      .Include(x => x.CommonDetailedDeclaration)
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

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION record for DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    public async Task<CommonDetailedDeclaration> GetCommonDetailedDeclaration(OperatorWhereUniqueInput uniqueId)
    {
        var operator = await _context
              .Operators.Where(operator => operator.Id == uniqueId.Id)
      .Include(operator => operator.CommonDetailedDeclaration)
      .FirstOrDefaultAsync();
        if (operator == null)
  {
            throw new NotFoundException();
        }
        return operator.CommonDetailedDeclaration.ToDto();
    }

}
