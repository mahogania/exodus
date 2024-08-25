using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class BaggageControlArticlesServiceBase : IBaggageControlArticlesService
{
    protected readonly TravelerDbContext _context;

    public BaggageControlArticlesServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one BaggageControlArticle
    /// </summary>
    public async Task<BaggageControlArticle> CreateBaggageControlArticle(
        BaggageControlArticleCreateInput createDto
    )
    {
        var baggageControlArticle = new BaggageControlArticleDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            baggageControlArticle.Id = createDto.Id;
        }
        if (createDto.GeneralTravelerInformationTpds != null)
        {
            baggageControlArticle.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        if (createDto.ImportDeclarations != null)
        {
            baggageControlArticle.ImportDeclarations = await _context
                .ImportDeclarations.Where(importDeclaration =>
                    createDto.ImportDeclarations.Select(t => t.Id).Contains(importDeclaration.Id)
                )
                .ToListAsync();
        }

        if (createDto.TpdControls != null)
        {
            baggageControlArticle.TpdControls = await _context
                .TpdControls.Where(tpdControl =>
                    createDto.TpdControls.Select(t => t.Id).Contains(tpdControl.Id)
                )
                .ToListAsync();
        }

        _context.BaggageControlArticles.Add(baggageControlArticle);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<BaggageControlArticleDbModel>(
            baggageControlArticle.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one BaggageControlArticle
    /// </summary>
    public async Task DeleteBaggageControlArticle(BaggageControlArticleWhereUniqueInput uniqueId)
    {
        var baggageControlArticle = await _context.BaggageControlArticles.FindAsync(uniqueId.Id);
        if (baggageControlArticle == null)
        {
            throw new NotFoundException();
        }

        _context.BaggageControlArticles.Remove(baggageControlArticle);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many BaggageControlArticles
    /// </summary>
    public async Task<List<BaggageControlArticle>> BaggageControlArticles(
        BaggageControlArticleFindManyArgs findManyArgs
    )
    {
        var baggageControlArticles = await _context
            .BaggageControlArticles.Include(x => x.GeneralTravelerInformationTpds)
            .Include(x => x.TpdControls)
            .Include(x => x.ImportDeclarations)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return baggageControlArticles.ConvertAll(baggageControlArticle =>
            baggageControlArticle.ToDto()
        );
    }

    /// <summary>
    /// Meta data about BaggageControlArticle records
    /// </summary>
    public async Task<MetadataDto> BaggageControlArticlesMeta(
        BaggageControlArticleFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .BaggageControlArticles.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one BaggageControlArticle
    /// </summary>
    public async Task<BaggageControlArticle> BaggageControlArticle(
        BaggageControlArticleWhereUniqueInput uniqueId
    )
    {
        var baggageControlArticles = await this.BaggageControlArticles(
            new BaggageControlArticleFindManyArgs
            {
                Where = new BaggageControlArticleWhereInput { Id = uniqueId.Id }
            }
        );
        var baggageControlArticle = baggageControlArticles.FirstOrDefault();
        if (baggageControlArticle == null)
        {
            throw new NotFoundException();
        }

        return baggageControlArticle;
    }

    /// <summary>
    /// Update one BaggageControlArticle
    /// </summary>
    public async Task UpdateBaggageControlArticle(
        BaggageControlArticleWhereUniqueInput uniqueId,
        BaggageControlArticleUpdateInput updateDto
    )
    {
        var baggageControlArticle = updateDto.ToModel(uniqueId);

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            baggageControlArticle.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        if (updateDto.TpdControls != null)
        {
            baggageControlArticle.TpdControls = await _context
                .TpdControls.Where(tpdControl =>
                    updateDto.TpdControls.Select(t => t).Contains(tpdControl.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ImportDeclarations != null)
        {
            baggageControlArticle.ImportDeclarations = await _context
                .ImportDeclarations.Where(importDeclaration =>
                    updateDto.ImportDeclarations.Select(t => t).Contains(importDeclaration.Id)
                )
                .ToListAsync();
        }

        _context.Entry(baggageControlArticle).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.BaggageControlArticles.Any(e => e.Id == baggageControlArticle.Id))
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
    /// Connect multiple GeneralTravelerInformationTpds records to BaggageControlArticle
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        BaggageControlArticleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .BaggageControlArticles.Include(x => x.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(t =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (generalTravelerInformationTpds.Count == 0)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpdsToConnect = generalTravelerInformationTpds.Except(
            parent.GeneralTravelerInformationTpds
        );

        foreach (var generalTravelerInformationTpd in generalTravelerInformationTpdsToConnect)
        {
            parent.GeneralTravelerInformationTpds.Add(generalTravelerInformationTpd);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from BaggageControlArticle
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        BaggageControlArticleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .BaggageControlArticles.Include(x => x.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(t =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var generalTravelerInformationTpd in generalTravelerInformationTpds)
        {
            parent.GeneralTravelerInformationTpds?.Remove(generalTravelerInformationTpd);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for BaggageControlArticle
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        BaggageControlArticleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs baggageControlArticleFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m => m.BaggageControlArticleId == uniqueId.Id)
            .ApplyWhere(baggageControlArticleFindManyArgs.Where)
            .ApplySkip(baggageControlArticleFindManyArgs.Skip)
            .ApplyTake(baggageControlArticleFindManyArgs.Take)
            .ApplyOrderBy(baggageControlArticleFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for BaggageControlArticle
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        BaggageControlArticleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var baggageControlArticle = await _context
            .BaggageControlArticles.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (baggageControlArticle == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(a =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (generalTravelerInformationTpds.Count == 0)
        {
            throw new NotFoundException();
        }

        baggageControlArticle.GeneralTravelerInformationTpds = generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple ImportDeclarations records to BaggageControlArticle
    /// </summary>
    public async Task ConnectImportDeclarations(
        BaggageControlArticleWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var parent = await _context
            .BaggageControlArticles.Include(x => x.ImportDeclarations)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var importDeclarations = await _context
            .ImportDeclarations.Where(t => importDeclarationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (importDeclarations.Count == 0)
        {
            throw new NotFoundException();
        }

        var importDeclarationsToConnect = importDeclarations.Except(parent.ImportDeclarations);

        foreach (var importDeclaration in importDeclarationsToConnect)
        {
            parent.ImportDeclarations.Add(importDeclaration);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple ImportDeclarations records from BaggageControlArticle
    /// </summary>
    public async Task DisconnectImportDeclarations(
        BaggageControlArticleWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var parent = await _context
            .BaggageControlArticles.Include(x => x.ImportDeclarations)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var importDeclarations = await _context
            .ImportDeclarations.Where(t => importDeclarationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var importDeclaration in importDeclarations)
        {
            parent.ImportDeclarations?.Remove(importDeclaration);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple ImportDeclarations records for BaggageControlArticle
    /// </summary>
    public async Task<List<ImportDeclaration>> FindImportDeclarations(
        BaggageControlArticleWhereUniqueInput uniqueId,
        ImportDeclarationFindManyArgs baggageControlArticleFindManyArgs
    )
    {
        var importDeclarations = await _context
            .ImportDeclarations.Where(m => m.BaggageControlArticleId == uniqueId.Id)
            .ApplyWhere(baggageControlArticleFindManyArgs.Where)
            .ApplySkip(baggageControlArticleFindManyArgs.Skip)
            .ApplyTake(baggageControlArticleFindManyArgs.Take)
            .ApplyOrderBy(baggageControlArticleFindManyArgs.SortBy)
            .ToListAsync();

        return importDeclarations.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple ImportDeclarations records for BaggageControlArticle
    /// </summary>
    public async Task UpdateImportDeclarations(
        BaggageControlArticleWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var baggageControlArticle = await _context
            .BaggageControlArticles.Include(t => t.ImportDeclarations)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (baggageControlArticle == null)
        {
            throw new NotFoundException();
        }

        var importDeclarations = await _context
            .ImportDeclarations.Where(a => importDeclarationsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (importDeclarations.Count == 0)
        {
            throw new NotFoundException();
        }

        baggageControlArticle.ImportDeclarations = importDeclarations;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple TpdControls records to BaggageControlArticle
    /// </summary>
    public async Task ConnectTpdControls(
        BaggageControlArticleWhereUniqueInput uniqueId,
        TpdControlWhereUniqueInput[] tpdControlsId
    )
    {
        var parent = await _context
            .BaggageControlArticles.Include(x => x.TpdControls)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var tpdControls = await _context
            .TpdControls.Where(t => tpdControlsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (tpdControls.Count == 0)
        {
            throw new NotFoundException();
        }

        var tpdControlsToConnect = tpdControls.Except(parent.TpdControls);

        foreach (var tpdControl in tpdControlsToConnect)
        {
            parent.TpdControls.Add(tpdControl);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple TpdControls records from BaggageControlArticle
    /// </summary>
    public async Task DisconnectTpdControls(
        BaggageControlArticleWhereUniqueInput uniqueId,
        TpdControlWhereUniqueInput[] tpdControlsId
    )
    {
        var parent = await _context
            .BaggageControlArticles.Include(x => x.TpdControls)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var tpdControls = await _context
            .TpdControls.Where(t => tpdControlsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var tpdControl in tpdControls)
        {
            parent.TpdControls?.Remove(tpdControl);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple TpdControls records for BaggageControlArticle
    /// </summary>
    public async Task<List<TpdControl>> FindTpdControls(
        BaggageControlArticleWhereUniqueInput uniqueId,
        TpdControlFindManyArgs baggageControlArticleFindManyArgs
    )
    {
        var tpdControls = await _context
            .TpdControls.Where(m => m.BaggageControlArticleId == uniqueId.Id)
            .ApplyWhere(baggageControlArticleFindManyArgs.Where)
            .ApplySkip(baggageControlArticleFindManyArgs.Skip)
            .ApplyTake(baggageControlArticleFindManyArgs.Take)
            .ApplyOrderBy(baggageControlArticleFindManyArgs.SortBy)
            .ToListAsync();

        return tpdControls.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple TpdControls records for BaggageControlArticle
    /// </summary>
    public async Task UpdateTpdControls(
        BaggageControlArticleWhereUniqueInput uniqueId,
        TpdControlWhereUniqueInput[] tpdControlsId
    )
    {
        var baggageControlArticle = await _context
            .BaggageControlArticles.Include(t => t.TpdControls)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (baggageControlArticle == null)
        {
            throw new NotFoundException();
        }

        var tpdControls = await _context
            .TpdControls.Where(a => tpdControlsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (tpdControls.Count == 0)
        {
            throw new NotFoundException();
        }

        baggageControlArticle.TpdControls = tpdControls;
        await _context.SaveChangesAsync();
    }
}
