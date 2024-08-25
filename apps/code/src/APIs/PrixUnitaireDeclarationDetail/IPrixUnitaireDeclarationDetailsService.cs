using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IPrixUnitaireDeclarationDetailsService
{
    /// <summary>
    /// Create one PrixUnitaireDeclarationDetail
    /// </summary>
    public Task<PrixUnitaireDeclarationDetail> CreatePrixUnitaireDeclarationDetail(
        PrixUnitaireDeclarationDetailCreateInput prixunitairedeclarationdetail
    );

    /// <summary>
    /// Delete one PrixUnitaireDeclarationDetail
    /// </summary>
    public Task DeletePrixUnitaireDeclarationDetail(
        PrixUnitaireDeclarationDetailWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many PrixUnitaireDeclarationDetails
    /// </summary>
    public Task<List<PrixUnitaireDeclarationDetail>> PrixUnitaireDeclarationDetails(
        PrixUnitaireDeclarationDetailFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about PrixUnitaireDeclarationDetail records
    /// </summary>
    public Task<MetadataDto> PrixUnitaireDeclarationDetailsMeta(
        PrixUnitaireDeclarationDetailFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one PrixUnitaireDeclarationDetail
    /// </summary>
    public Task<PrixUnitaireDeclarationDetail> PrixUnitaireDeclarationDetail(
        PrixUnitaireDeclarationDetailWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one PrixUnitaireDeclarationDetail
    /// </summary>
    public Task UpdatePrixUnitaireDeclarationDetail(
        PrixUnitaireDeclarationDetailWhereUniqueInput uniqueId,
        PrixUnitaireDeclarationDetailUpdateInput updateDto
    );
}
