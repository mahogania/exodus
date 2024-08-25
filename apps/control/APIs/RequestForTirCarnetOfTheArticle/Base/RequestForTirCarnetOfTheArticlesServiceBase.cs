using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class RequestForTirCarnetOfTheArticlesServiceBase
    : IRequestForTirCarnetOfTheArticlesService
{
    protected readonly ControlDbContext _context;

    public RequestForTirCarnetOfTheArticlesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    public async Task<RequestForTirCarnetOfTheArticle> CreateRequestForTirCarnetOfTheArticle(
        RequestForTirCarnetOfTheArticleCreateInput createDto
    )
    {
        var requestForTirCarnetOfTheArticle = new RequestForTirCarnetOfTheArticleDbModel
        {
            ArticleSequenceNumber = createDto.ArticleSequenceNumber,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DescCtn = createDto.DescCtn,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            PackageDescription = createDto.PackageDescription,
            Packaging = createDto.Packaging,
            SuppressionOn = createDto.SuppressionOn,
            TirRegistrationNumber = createDto.TirRegistrationNumber,
            UpdatedAt = createDto.UpdatedAt,
            Weight = createDto.Weight
        };

        if (createDto.Id != null) requestForTirCarnetOfTheArticle.Id = createDto.Id;

        _context.RequestForTirCarnetOfTheArticles.Add(requestForTirCarnetOfTheArticle);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RequestForTirCarnetOfTheArticleDbModel>(
            requestForTirCarnetOfTheArticle.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    public async Task DeleteRequestForTirCarnetOfTheArticle(
        RequestForTirCarnetOfTheArticleWhereUniqueInput uniqueId
    )
    {
        var requestForTirCarnetOfTheArticle =
            await _context.RequestForTirCarnetOfTheArticles.FindAsync(uniqueId.Id);
        if (requestForTirCarnetOfTheArticle == null) throw new NotFoundException();

        _context.RequestForTirCarnetOfTheArticles.Remove(requestForTirCarnetOfTheArticle);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many REQUEST FOR TIR CARNET OF THE ARTICLES
    /// </summary>
    public async Task<List<RequestForTirCarnetOfTheArticle>> RequestForTirCarnetOfTheArticles(
        RequestForTirCarnetOfTheArticleFindManyArgs findManyArgs
    )
    {
        var requestForTirCarnetOfTheArticles = await _context
            .RequestForTirCarnetOfTheArticles.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return requestForTirCarnetOfTheArticles.ConvertAll(requestForTirCarnetOfTheArticle =>
            requestForTirCarnetOfTheArticle.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about REQUEST FOR TIR CARNET OF THE ARTICLE records
    /// </summary>
    public async Task<MetadataDto> RequestForTirCarnetOfTheArticlesMeta(
        RequestForTirCarnetOfTheArticleFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .RequestForTirCarnetOfTheArticles.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    public async Task<RequestForTirCarnetOfTheArticle> RequestForTirCarnetOfTheArticle(
        RequestForTirCarnetOfTheArticleWhereUniqueInput uniqueId
    )
    {
        var requestForTirCarnetOfTheArticles = await RequestForTirCarnetOfTheArticles(
            new RequestForTirCarnetOfTheArticleFindManyArgs
            {
                Where = new RequestForTirCarnetOfTheArticleWhereInput { Id = uniqueId.Id }
            }
        );
        var requestForTirCarnetOfTheArticle = requestForTirCarnetOfTheArticles.FirstOrDefault();
        if (requestForTirCarnetOfTheArticle == null) throw new NotFoundException();

        return requestForTirCarnetOfTheArticle;
    }

    /// <summary>
    ///     Update one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    public async Task UpdateRequestForTirCarnetOfTheArticle(
        RequestForTirCarnetOfTheArticleWhereUniqueInput uniqueId,
        RequestForTirCarnetOfTheArticleUpdateInput updateDto
    )
    {
        var requestForTirCarnetOfTheArticle = updateDto.ToModel(uniqueId);

        _context.Entry(requestForTirCarnetOfTheArticle).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.RequestForTirCarnetOfTheArticles.Any(e =>
                    e.Id == requestForTirCarnetOfTheArticle.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
