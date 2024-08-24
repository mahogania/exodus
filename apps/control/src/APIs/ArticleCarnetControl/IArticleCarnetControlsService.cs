using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IArticleCarnetControlsService
{
    /// <summary>
    /// Create one Article Carnet Control
    /// </summary>
    public Task<ArticleCarnetControl> CreateArticleCarnetControl(
        ArticleCarnetControlCreateInput articlecarnetcontrol
    );

    /// <summary>
    /// Delete one Article Carnet Control
    /// </summary>
    public Task DeleteArticleCarnetControl(ArticleCarnetControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Article Carnet Controls
    /// </summary>
    public Task<List<ArticleCarnetControl>> ArticleCarnetControls(
        ArticleCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Article Carnet Control records
    /// </summary>
    public Task<MetadataDto> ArticleCarnetControlsMeta(
        ArticleCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Article Carnet Control
    /// </summary>
    public Task<ArticleCarnetControl> ArticleCarnetControl(
        ArticleCarnetControlWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Article Carnet Control
    /// </summary>
    public Task UpdateArticleCarnetControl(
        ArticleCarnetControlWhereUniqueInput uniqueId,
        ArticleCarnetControlUpdateInput updateDto
    );

    /// <summary>
    /// Get a Article Carnet Request record for Article Carnet Control
    /// </summary>
    public Task<ArticleCarnetRequest> GetArticleCarnetRequest(
        ArticleCarnetControlWhereUniqueInput uniqueId
    );
}
