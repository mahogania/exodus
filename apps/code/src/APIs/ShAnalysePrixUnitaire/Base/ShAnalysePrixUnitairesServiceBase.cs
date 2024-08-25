using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ShAnalysePrixUnitairesServiceBase : IShAnalysePrixUnitairesService
{
    protected readonly CodeDbContext _context;

    public ShAnalysePrixUnitairesServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ShAnalysePrixUnitaire
    /// </summary>
    public async Task<ShAnalysePrixUnitaire> CreateShAnalysePrixUnitaire(
        ShAnalysePrixUnitaireCreateInput createDto
    )
    {
        var shAnalysePrixUnitaire = new ShAnalysePrixUnitaireDbModel
        {
            CodePaysOrigine = createDto.CodePaysOrigine,
            CodeSh = createDto.CodeSh,
            CodeUniteQuantite = createDto.CodeUniteQuantite,
            CreatedAt = createDto.CreatedAt,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            DateValidation = createDto.DateValidation,
            ModificateurFinalId = createDto.ModificateurFinalId,
            MontantNcyFacture = createDto.MontantNcyFacture,
            MontantUsdFacture = createDto.MontantUsdFacture,
            NomMarque = createDto.NomMarque,
            NumeroArticle = createDto.NumeroArticle,
            NumeroDeclarationDetail = createDto.NumeroDeclarationDetail,
            NumeroIdentificationExportateur = createDto.NumeroIdentificationExportateur,
            NumeroIdentificationImportateur = createDto.NumeroIdentificationImportateur,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            PrixNcyUnitaire = createDto.PrixNcyUnitaire,
            PrixUsdUnitaire = createDto.PrixUsdUnitaire,
            Quantite = createDto.Quantite,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            shAnalysePrixUnitaire.Id = createDto.Id;
        }

        _context.ShAnalysePrixUnitaires.Add(shAnalysePrixUnitaire);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ShAnalysePrixUnitaireDbModel>(
            shAnalysePrixUnitaire.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ShAnalysePrixUnitaire
    /// </summary>
    public async Task DeleteShAnalysePrixUnitaire(ShAnalysePrixUnitaireWhereUniqueInput uniqueId)
    {
        var shAnalysePrixUnitaire = await _context.ShAnalysePrixUnitaires.FindAsync(uniqueId.Id);
        if (shAnalysePrixUnitaire == null)
        {
            throw new NotFoundException();
        }

        _context.ShAnalysePrixUnitaires.Remove(shAnalysePrixUnitaire);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ShAnalysePrixUnitaires
    /// </summary>
    public async Task<List<ShAnalysePrixUnitaire>> ShAnalysePrixUnitaires(
        ShAnalysePrixUnitaireFindManyArgs findManyArgs
    )
    {
        var shAnalysePrixUnitaires = await _context
            .ShAnalysePrixUnitaires.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return shAnalysePrixUnitaires.ConvertAll(shAnalysePrixUnitaire =>
            shAnalysePrixUnitaire.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ShAnalysePrixUnitaire records
    /// </summary>
    public async Task<MetadataDto> ShAnalysePrixUnitairesMeta(
        ShAnalysePrixUnitaireFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ShAnalysePrixUnitaires.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ShAnalysePrixUnitaire
    /// </summary>
    public async Task<ShAnalysePrixUnitaire> ShAnalysePrixUnitaire(
        ShAnalysePrixUnitaireWhereUniqueInput uniqueId
    )
    {
        var shAnalysePrixUnitaires = await this.ShAnalysePrixUnitaires(
            new ShAnalysePrixUnitaireFindManyArgs
            {
                Where = new ShAnalysePrixUnitaireWhereInput { Id = uniqueId.Id }
            }
        );
        var shAnalysePrixUnitaire = shAnalysePrixUnitaires.FirstOrDefault();
        if (shAnalysePrixUnitaire == null)
        {
            throw new NotFoundException();
        }

        return shAnalysePrixUnitaire;
    }

    /// <summary>
    /// Update one ShAnalysePrixUnitaire
    /// </summary>
    public async Task UpdateShAnalysePrixUnitaire(
        ShAnalysePrixUnitaireWhereUniqueInput uniqueId,
        ShAnalysePrixUnitaireUpdateInput updateDto
    )
    {
        var shAnalysePrixUnitaire = updateDto.ToModel(uniqueId);

        _context.Entry(shAnalysePrixUnitaire).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ShAnalysePrixUnitaires.Any(e => e.Id == shAnalysePrixUnitaire.Id))
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
