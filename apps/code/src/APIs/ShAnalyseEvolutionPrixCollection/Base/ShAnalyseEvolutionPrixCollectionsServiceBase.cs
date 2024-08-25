using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ShAnalyseEvolutionPrixCollectionsServiceBase
    : IShAnalyseEvolutionPrixCollectionsService
{
    protected readonly CodeDbContext _context;

    public ShAnalyseEvolutionPrixCollectionsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ShAnalyseEvolutionPrixCollection
    /// </summary>
    public async Task<ShAnalyseEvolutionPrixCollection> CreateShAnalyseEvolutionPrixCollection(
        ShAnalyseEvolutionPrixCollectionCreateInput createDto
    )
    {
        var shAnalyseEvolutionPrixCollection = new ShAnalyseEvolutionPrixCollectionDbModel
        {
            AnneeAddition = createDto.AnneeAddition,
            CodeChampPeriodeAddition = createDto.CodeChampPeriodeAddition,
            CodeSh = createDto.CodeSh,
            CreatedAt = createDto.CreatedAt,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = createDto.ModificateurFinalId,
            MoisAddition = createDto.MoisAddition,
            MontantNcyFactureDernierePeriodeAddition =
                createDto.MontantNcyFactureDernierePeriodeAddition,
            MontantNcyFactureMoisAddition = createDto.MontantNcyFactureMoisAddition,
            NombreDeclarationsDernierePeriodeAddition =
                createDto.NombreDeclarationsDernierePeriodeAddition,
            NombreDeclarationsMoisAddition = createDto.NombreDeclarationsMoisAddition,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            SuppressionOn = createDto.SuppressionOn,
            TauxAugmentationMontantFacture = createDto.TauxAugmentationMontantFacture,
            TauxAugmentationNombreDeclarations = createDto.TauxAugmentationNombreDeclarations,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            shAnalyseEvolutionPrixCollection.Id = createDto.Id;
        }

        _context.ShAnalyseEvolutionPrixCollections.Add(shAnalyseEvolutionPrixCollection);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ShAnalyseEvolutionPrixCollectionDbModel>(
            shAnalyseEvolutionPrixCollection.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ShAnalyseEvolutionPrixCollection
    /// </summary>
    public async Task DeleteShAnalyseEvolutionPrixCollection(
        ShAnalyseEvolutionPrixCollectionWhereUniqueInput uniqueId
    )
    {
        var shAnalyseEvolutionPrixCollection =
            await _context.ShAnalyseEvolutionPrixCollections.FindAsync(uniqueId.Id);
        if (shAnalyseEvolutionPrixCollection == null)
        {
            throw new NotFoundException();
        }

        _context.ShAnalyseEvolutionPrixCollections.Remove(shAnalyseEvolutionPrixCollection);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ShAnalyseEvolutionPrixCollections
    /// </summary>
    public async Task<List<ShAnalyseEvolutionPrixCollection>> ShAnalyseEvolutionPrixCollections(
        ShAnalyseEvolutionPrixCollectionFindManyArgs findManyArgs
    )
    {
        var shAnalyseEvolutionPrixCollections = await _context
            .ShAnalyseEvolutionPrixCollections.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return shAnalyseEvolutionPrixCollections.ConvertAll(shAnalyseEvolutionPrixCollection =>
            shAnalyseEvolutionPrixCollection.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ShAnalyseEvolutionPrixCollection records
    /// </summary>
    public async Task<MetadataDto> ShAnalyseEvolutionPrixCollectionsMeta(
        ShAnalyseEvolutionPrixCollectionFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ShAnalyseEvolutionPrixCollections.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ShAnalyseEvolutionPrixCollection
    /// </summary>
    public async Task<ShAnalyseEvolutionPrixCollection> ShAnalyseEvolutionPrixCollection(
        ShAnalyseEvolutionPrixCollectionWhereUniqueInput uniqueId
    )
    {
        var shAnalyseEvolutionPrixCollections = await this.ShAnalyseEvolutionPrixCollections(
            new ShAnalyseEvolutionPrixCollectionFindManyArgs
            {
                Where = new ShAnalyseEvolutionPrixCollectionWhereInput { Id = uniqueId.Id }
            }
        );
        var shAnalyseEvolutionPrixCollection = shAnalyseEvolutionPrixCollections.FirstOrDefault();
        if (shAnalyseEvolutionPrixCollection == null)
        {
            throw new NotFoundException();
        }

        return shAnalyseEvolutionPrixCollection;
    }

    /// <summary>
    /// Update one ShAnalyseEvolutionPrixCollection
    /// </summary>
    public async Task UpdateShAnalyseEvolutionPrixCollection(
        ShAnalyseEvolutionPrixCollectionWhereUniqueInput uniqueId,
        ShAnalyseEvolutionPrixCollectionUpdateInput updateDto
    )
    {
        var shAnalyseEvolutionPrixCollection = updateDto.ToModel(uniqueId);

        _context.Entry(shAnalyseEvolutionPrixCollection).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ShAnalyseEvolutionPrixCollections.Any(e =>
                    e.Id == shAnalyseEvolutionPrixCollection.Id
                )
            )
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
