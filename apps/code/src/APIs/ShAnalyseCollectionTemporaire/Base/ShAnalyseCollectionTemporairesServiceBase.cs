using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ShAnalyseCollectionTemporairesServiceBase
    : IShAnalyseCollectionTemporairesService
{
    protected readonly CodeDbContext _context;

    public ShAnalyseCollectionTemporairesServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ShAnalyseCollectionTemporaire
    /// </summary>
    public async Task<ShAnalyseCollectionTemporaire> CreateShAnalyseCollectionTemporaire(
        ShAnalyseCollectionTemporaireCreateInput createDto
    )
    {
        var shAnalyseCollectionTemporaire = new ShAnalyseCollectionTemporaireDbModel
        {
            ClassementGroupesPrixNcyUnitaires = createDto.ClassementGroupesPrixNcyUnitaires,
            ClassementGroupesPrixUsdUnitaires = createDto.ClassementGroupesPrixUsdUnitaires,
            ClassementPrixNcyUnitaires = createDto.ClassementPrixNcyUnitaires,
            ClassementPrixUsdUnitaires = createDto.ClassementPrixUsdUnitaires,
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
            PoidsParUnite = createDto.PoidsParUnite,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            PrixNcyUnitaire = createDto.PrixNcyUnitaire,
            PrixUsdUnitaire = createDto.PrixUsdUnitaire,
            Quantite = createDto.Quantite,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            shAnalyseCollectionTemporaire.Id = createDto.Id;
        }

        _context.ShAnalyseCollectionTemporaires.Add(shAnalyseCollectionTemporaire);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ShAnalyseCollectionTemporaireDbModel>(
            shAnalyseCollectionTemporaire.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ShAnalyseCollectionTemporaire
    /// </summary>
    public async Task DeleteShAnalyseCollectionTemporaire(
        ShAnalyseCollectionTemporaireWhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollectionTemporaire = await _context.ShAnalyseCollectionTemporaires.FindAsync(
            uniqueId.Id
        );
        if (shAnalyseCollectionTemporaire == null)
        {
            throw new NotFoundException();
        }

        _context.ShAnalyseCollectionTemporaires.Remove(shAnalyseCollectionTemporaire);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ShAnalyseCollectionTemporaires
    /// </summary>
    public async Task<List<ShAnalyseCollectionTemporaire>> ShAnalyseCollectionTemporaires(
        ShAnalyseCollectionTemporaireFindManyArgs findManyArgs
    )
    {
        var shAnalyseCollectionTemporaires = await _context
            .ShAnalyseCollectionTemporaires.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return shAnalyseCollectionTemporaires.ConvertAll(shAnalyseCollectionTemporaire =>
            shAnalyseCollectionTemporaire.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ShAnalyseCollectionTemporaire records
    /// </summary>
    public async Task<MetadataDto> ShAnalyseCollectionTemporairesMeta(
        ShAnalyseCollectionTemporaireFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ShAnalyseCollectionTemporaires.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ShAnalyseCollectionTemporaire
    /// </summary>
    public async Task<ShAnalyseCollectionTemporaire> ShAnalyseCollectionTemporaire(
        ShAnalyseCollectionTemporaireWhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollectionTemporaires = await this.ShAnalyseCollectionTemporaires(
            new ShAnalyseCollectionTemporaireFindManyArgs
            {
                Where = new ShAnalyseCollectionTemporaireWhereInput { Id = uniqueId.Id }
            }
        );
        var shAnalyseCollectionTemporaire = shAnalyseCollectionTemporaires.FirstOrDefault();
        if (shAnalyseCollectionTemporaire == null)
        {
            throw new NotFoundException();
        }

        return shAnalyseCollectionTemporaire;
    }

    /// <summary>
    /// Update one ShAnalyseCollectionTemporaire
    /// </summary>
    public async Task UpdateShAnalyseCollectionTemporaire(
        ShAnalyseCollectionTemporaireWhereUniqueInput uniqueId,
        ShAnalyseCollectionTemporaireUpdateInput updateDto
    )
    {
        var shAnalyseCollectionTemporaire = updateDto.ToModel(uniqueId);

        _context.Entry(shAnalyseCollectionTemporaire).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ShAnalyseCollectionTemporaires.Any(e =>
                    e.Id == shAnalyseCollectionTemporaire.Id
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
