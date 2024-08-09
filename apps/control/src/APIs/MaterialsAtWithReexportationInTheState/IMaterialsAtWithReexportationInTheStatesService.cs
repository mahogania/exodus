using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IMaterialsAtWithReexportationInTheStatesService
{
    /// <summary>
    /// Create one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task<MaterialsAtWithReexportationInTheState> CreateMaterialsAtWithReexportationInTheState(
        MaterialsAtWithReexportationInTheStateCreateInput materialsatwithreexportationinthestate
    );

    /// <summary>
    /// Delete one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task DeleteMaterialsAtWithReexportationInTheState(
        MaterialsAtWithReexportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many MATERIALS AT WITH REEXPORTATION IN THE STATES
    /// </summary>
    public Task<
        List<MaterialsAtWithReexportationInTheState>
    > MaterialsAtWithReexportationInTheStates(
        MaterialsAtWithReexportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about MATERIALS AT WITH REEXPORTATION IN THE STATE records
    /// </summary>
    public Task<MetadataDto> MaterialsAtWithReexportationInTheStatesMeta(
        MaterialsAtWithReexportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task<MaterialsAtWithReexportationInTheState> MaterialsAtWithReexportationInTheState(
        MaterialsAtWithReexportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task UpdateMaterialsAtWithReexportationInTheState(
        MaterialsAtWithReexportationInTheStateWhereUniqueInput uniqueId,
        MaterialsAtWithReexportationInTheStateUpdateInput updateDto
    );
}
