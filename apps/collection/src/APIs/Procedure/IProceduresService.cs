using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IProceduresService
{
    /// <summary>
    /// Create one PROCEDURE
    /// </summary>
    public Task<Procedure> CreateProcedure(ProcedureCreateInput procedure);

    /// <summary>
    /// Delete one PROCEDURE
    /// </summary>
    public Task DeleteProcedure(ProcedureWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many PROCEDURES
    /// </summary>
    public Task<List<Procedure>> Procedures(ProcedureFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about PROCEDURE records
    /// </summary>
    public Task<MetadataDto> ProceduresMeta(ProcedureFindManyArgs findManyArgs);

    /// <summary>
    /// Get one PROCEDURE
    /// </summary>
    public Task<Procedure> Procedure(ProcedureWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one PROCEDURE
    /// </summary>
    public Task UpdateProcedure(ProcedureWhereUniqueInput uniqueId, ProcedureUpdateInput updateDto);
}
