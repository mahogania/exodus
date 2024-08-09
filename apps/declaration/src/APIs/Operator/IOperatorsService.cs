using Statement.APIs.Dtos;
using Statement.APIs.Common;

namespace Statement.APIs;

public interface IOperatorsService
{
    /// <summary>
    /// Create one Operator
    /// </summary>
    public Task<Operator> CreateOperator(OperatorCreateInput operator);
    /// <summary>
    /// Delete one Operator
    /// </summary>
    public Task DeleteOperator(OperatorWhereUniqueInput uniqueId);
    /// <summary>
    /// Find many Operators
    /// </summary>
    public Task<List<Operator>> Operators(OperatorFindManyArgs findManyArgs);
    /// <summary>
    /// Meta data about Operator records
    /// </summary>
    public Task<MetadataDto> OperatorsMeta(OperatorFindManyArgs findManyArgs);
    /// <summary>
    /// Get one Operator
    /// </summary>
    public Task<Operator> Operator(OperatorWhereUniqueInput uniqueId);
    /// <summary>
    /// Update one Operator
    /// </summary>
    public Task UpdateOperator(OperatorWhereUniqueInput uniqueId, OperatorUpdateInput updateDto);
}
