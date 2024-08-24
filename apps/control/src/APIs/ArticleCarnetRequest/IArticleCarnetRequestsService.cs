using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IArticleCarnetRequestsService
{
    /// <summary>
    /// Create one Article Carnet Request
    /// </summary>
    public Task<ArticleCarnetRequest> CreateArticleCarnetRequest(
        ArticleCarnetRequestCreateInput articlecarnetrequest
    );

    /// <summary>
    /// Delete one Article Carnet Request
    /// </summary>
    public Task DeleteArticleCarnetRequest(ArticleCarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Article Carnet Requests
    /// </summary>
    public Task<List<ArticleCarnetRequest>> ArticleCarnetRequests(
        ArticleCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Article Carnet Request records
    /// </summary>
    public Task<MetadataDto> ArticleCarnetRequestsMeta(
        ArticleCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Article Carnet Request
    /// </summary>
    public Task<ArticleCarnetRequest> ArticleCarnetRequest(
        ArticleCarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Article Carnet Request
    /// </summary>
    public Task UpdateArticleCarnetRequest(
        ArticleCarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestUpdateInput updateDto
    );

    /// <summary>
    /// Get a Article Carnet Control record for Article Carnet Request
    /// </summary>
    public Task<ArticleCarnetControl> GetArticleCarnetControl(
        ArticleCarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Get a Carnet Request record for Article Carnet Request
    /// </summary>
    public Task<CarnetRequest> GetCarnetRequest(ArticleCarnetRequestWhereUniqueInput uniqueId);
}
