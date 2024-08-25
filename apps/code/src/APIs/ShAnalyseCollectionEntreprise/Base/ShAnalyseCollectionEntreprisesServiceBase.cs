using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ShAnalyseCollectionEntreprisesServiceBase
    : IShAnalyseCollectionEntreprisesService
{
    protected readonly CodeDbContext _context;

    public ShAnalyseCollectionEntreprisesServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ShAnalyseCollectionEntreprise
    /// </summary>
    public async Task<ShAnalyseCollectionEntreprise> CreateShAnalyseCollectionEntreprise(
        ShAnalyseCollectionEntrepriseCreateInput createDto
    )
    {
        var shAnalyseCollectionEntreprise = new ShAnalyseCollectionEntrepriseDbModel
        {
            AnneeAddition = createDto.AnneeAddition,
            CodeChampPeriodeAddition = createDto.CodeChampPeriodeAddition,
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
            RegistreCommerce = createDto.RegistreCommerce,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            shAnalyseCollectionEntreprise.Id = createDto.Id;
        }

        _context.ShAnalyseCollectionEntreprises.Add(shAnalyseCollectionEntreprise);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ShAnalyseCollectionEntrepriseDbModel>(
            shAnalyseCollectionEntreprise.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ShAnalyseCollectionEntreprise
    /// </summary>
    public async Task DeleteShAnalyseCollectionEntreprise(
        ShAnalyseCollectionEntrepriseWhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollectionEntreprise = await _context.ShAnalyseCollectionEntreprises.FindAsync(
            uniqueId.Id
        );
        if (shAnalyseCollectionEntreprise == null)
        {
            throw new NotFoundException();
        }

        _context.ShAnalyseCollectionEntreprises.Remove(shAnalyseCollectionEntreprise);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ShAnalyseCollectionEntreprises
    /// </summary>
    public async Task<List<ShAnalyseCollectionEntreprise>> ShAnalyseCollectionEntreprises(
        ShAnalyseCollectionEntrepriseFindManyArgs findManyArgs
    )
    {
        var shAnalyseCollectionEntreprises = await _context
            .ShAnalyseCollectionEntreprises.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return shAnalyseCollectionEntreprises.ConvertAll(shAnalyseCollectionEntreprise =>
            shAnalyseCollectionEntreprise.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ShAnalyseCollectionEntreprise records
    /// </summary>
    public async Task<MetadataDto> ShAnalyseCollectionEntreprisesMeta(
        ShAnalyseCollectionEntrepriseFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ShAnalyseCollectionEntreprises.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ShAnalyseCollectionEntreprise
    /// </summary>
    public async Task<ShAnalyseCollectionEntreprise> ShAnalyseCollectionEntreprise(
        ShAnalyseCollectionEntrepriseWhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollectionEntreprises = await this.ShAnalyseCollectionEntreprises(
            new ShAnalyseCollectionEntrepriseFindManyArgs
            {
                Where = new ShAnalyseCollectionEntrepriseWhereInput { Id = uniqueId.Id }
            }
        );
        var shAnalyseCollectionEntreprise = shAnalyseCollectionEntreprises.FirstOrDefault();
        if (shAnalyseCollectionEntreprise == null)
        {
            throw new NotFoundException();
        }

        return shAnalyseCollectionEntreprise;
    }

    /// <summary>
    /// Update one ShAnalyseCollectionEntreprise
    /// </summary>
    public async Task UpdateShAnalyseCollectionEntreprise(
        ShAnalyseCollectionEntrepriseWhereUniqueInput uniqueId,
        ShAnalyseCollectionEntrepriseUpdateInput updateDto
    )
    {
        var shAnalyseCollectionEntreprise = updateDto.ToModel(uniqueId);

        _context.Entry(shAnalyseCollectionEntreprise).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ShAnalyseCollectionEntreprises.Any(e =>
                    e.Id == shAnalyseCollectionEntreprise.Id
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
