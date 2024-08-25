using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ShAnalyseCollectionsServiceBase : IShAnalyseCollectionsService
{
    protected readonly CodeDbContext _context;

    public ShAnalyseCollectionsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ShAnalyseCollection
    /// </summary>
    public async Task<ShAnalyseCollection> CreateShAnalyseCollection(
        ShAnalyseCollectionCreateInput createDto
    )
    {
        var shAnalyseCollection = new ShAnalyseCollectionDbModel
        {
            AnneeAddition = createDto.AnneeAddition,
            CodeChampPeriodeAddition = createDto.CodeChampPeriodeAddition,
            CodePaysOriginePrincipal = createDto.CodePaysOriginePrincipal,
            CodeSh = createDto.CodeSh,
            CreatedAt = createDto.CreatedAt,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = createDto.ModificateurFinalId,
            MoisAddition = createDto.MoisAddition,
            MontantNcyFacture = createDto.MontantNcyFacture,
            MontantNcyUniteMaximale = createDto.MontantNcyUniteMaximale,
            MontantNcyUniteMinimale = createDto.MontantNcyUniteMinimale,
            MontantUsdFacture = createDto.MontantUsdFacture,
            MontantUsdUniteMaximale = createDto.MontantUsdUniteMaximale,
            MontantUsdUniteMinimale = createDto.MontantUsdUniteMinimale,
            NombreCasArticles = createDto.NombreCasArticles,
            NombreDeclarations = createDto.NombreDeclarations,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            PrixUnitaireNcyEcartType = createDto.PrixUnitaireNcyEcartType,
            PrixUnitaireNcyLiquide = createDto.PrixUnitaireNcyLiquide,
            PrixUnitaireUsdEcartType = createDto.PrixUnitaireUsdEcartType,
            PrixUnitaireUsdLiquide = createDto.PrixUnitaireUsdLiquide,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            shAnalyseCollection.Id = createDto.Id;
        }

        _context.ShAnalyseCollections.Add(shAnalyseCollection);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ShAnalyseCollectionDbModel>(shAnalyseCollection.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ShAnalyseCollection
    /// </summary>
    public async Task DeleteShAnalyseCollection(ShAnalyseCollectionWhereUniqueInput uniqueId)
    {
        var shAnalyseCollection = await _context.ShAnalyseCollections.FindAsync(uniqueId.Id);
        if (shAnalyseCollection == null)
        {
            throw new NotFoundException();
        }

        _context.ShAnalyseCollections.Remove(shAnalyseCollection);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ShAnalyseCollections
    /// </summary>
    public async Task<List<ShAnalyseCollection>> ShAnalyseCollections(
        ShAnalyseCollectionFindManyArgs findManyArgs
    )
    {
        var shAnalyseCollections = await _context
            .ShAnalyseCollections.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return shAnalyseCollections.ConvertAll(shAnalyseCollection => shAnalyseCollection.ToDto());
    }

    /// <summary>
    /// Meta data about ShAnalyseCollection records
    /// </summary>
    public async Task<MetadataDto> ShAnalyseCollectionsMeta(
        ShAnalyseCollectionFindManyArgs findManyArgs
    )
    {
        var count = await _context.ShAnalyseCollections.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ShAnalyseCollection
    /// </summary>
    public async Task<ShAnalyseCollection> ShAnalyseCollection(
        ShAnalyseCollectionWhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollections = await this.ShAnalyseCollections(
            new ShAnalyseCollectionFindManyArgs
            {
                Where = new ShAnalyseCollectionWhereInput { Id = uniqueId.Id }
            }
        );
        var shAnalyseCollection = shAnalyseCollections.FirstOrDefault();
        if (shAnalyseCollection == null)
        {
            throw new NotFoundException();
        }

        return shAnalyseCollection;
    }

    /// <summary>
    /// Update one ShAnalyseCollection
    /// </summary>
    public async Task UpdateShAnalyseCollection(
        ShAnalyseCollectionWhereUniqueInput uniqueId,
        ShAnalyseCollectionUpdateInput updateDto
    )
    {
        var shAnalyseCollection = updateDto.ToModel(uniqueId);

        _context.Entry(shAnalyseCollection).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ShAnalyseCollections.Any(e => e.Id == shAnalyseCollection.Id))
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
