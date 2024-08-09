using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class InfosGoodsToBeReprovisionedsServiceBase : IInfosGoodsToBeReprovisionedsService
{
    protected readonly ControlDbContext _context;

    public InfosGoodsToBeReprovisionedsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    public async Task<InfosGoodsToBeReprovisioned> CreateInfosGoodsToBeReprovisioned(
        InfosGoodsToBeReprovisionedCreateInput createDto
    )
    {
        var infosGoodsToBeReprovisioned = new InfosGoodsToBeReprovisionedDbModel
        {
            CommercialDesignationOfGoods = createDto.CommercialDesignationOfGoods,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            NatureOfTheGoods = createDto.NatureOfTheGoods,
            NumberOfTheConcernedArticle = createDto.NumberOfTheConcernedArticle,
            Origin = createDto.Origin,
            ProposedMeansForTheQuantitativeAndTechnicalControlOfEquivalence =
                createDto.ProposedMeansForTheQuantitativeAndTechnicalControlOfEquivalence,
            Provenance = createDto.Provenance,
            QuantityIncludingNonRecoverableWaste = createDto.QuantityIncludingNonRecoverableWaste,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferencesOfTheConcernedArticleModelS = createDto.ReferencesOfTheConcernedArticleModelS,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SequenceNumber = createDto.SequenceNumber,
            SptNumber = createDto.SptNumber,
            SuppressionOn = createDto.SuppressionOn,
            TechnicalCharacteristics = createDto.TechnicalCharacteristics,
            TechnicalDesignationOfGoods = createDto.TechnicalDesignationOfGoods,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            infosGoodsToBeReprovisioned.Id = createDto.Id;
        }

        _context.InfosGoodsToBeReprovisioneds.Add(infosGoodsToBeReprovisioned);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InfosGoodsToBeReprovisionedDbModel>(
            infosGoodsToBeReprovisioned.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    public async Task DeleteInfosGoodsToBeReprovisioned(
        InfosGoodsToBeReprovisionedWhereUniqueInput uniqueId
    )
    {
        var infosGoodsToBeReprovisioned = await _context.InfosGoodsToBeReprovisioneds.FindAsync(
            uniqueId.Id
        );
        if (infosGoodsToBeReprovisioned == null)
        {
            throw new NotFoundException();
        }

        _context.InfosGoodsToBeReprovisioneds.Remove(infosGoodsToBeReprovisioned);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many INFOS GOODS TO BE REPROVISIONEDS
    /// </summary>
    public async Task<List<InfosGoodsToBeReprovisioned>> InfosGoodsToBeReprovisioneds(
        InfosGoodsToBeReprovisionedFindManyArgs findManyArgs
    )
    {
        var infosGoodsToBeReprovisioneds = await _context
            .InfosGoodsToBeReprovisioneds.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return infosGoodsToBeReprovisioneds.ConvertAll(infosGoodsToBeReprovisioned =>
            infosGoodsToBeReprovisioned.ToDto()
        );
    }

    /// <summary>
    /// Meta data about INFOS GOODS TO BE REPROVISIONED records
    /// </summary>
    public async Task<MetadataDto> InfosGoodsToBeReprovisionedsMeta(
        InfosGoodsToBeReprovisionedFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InfosGoodsToBeReprovisioneds.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    public async Task<InfosGoodsToBeReprovisioned> InfosGoodsToBeReprovisioned(
        InfosGoodsToBeReprovisionedWhereUniqueInput uniqueId
    )
    {
        var infosGoodsToBeReprovisioneds = await this.InfosGoodsToBeReprovisioneds(
            new InfosGoodsToBeReprovisionedFindManyArgs
            {
                Where = new InfosGoodsToBeReprovisionedWhereInput { Id = uniqueId.Id }
            }
        );
        var infosGoodsToBeReprovisioned = infosGoodsToBeReprovisioneds.FirstOrDefault();
        if (infosGoodsToBeReprovisioned == null)
        {
            throw new NotFoundException();
        }

        return infosGoodsToBeReprovisioned;
    }

    /// <summary>
    /// Update one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    public async Task UpdateInfosGoodsToBeReprovisioned(
        InfosGoodsToBeReprovisionedWhereUniqueInput uniqueId,
        InfosGoodsToBeReprovisionedUpdateInput updateDto
    )
    {
        var infosGoodsToBeReprovisioned = updateDto.ToModel(uniqueId);

        _context.Entry(infosGoodsToBeReprovisioned).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.InfosGoodsToBeReprovisioneds.Any(e =>
                    e.Id == infosGoodsToBeReprovisioned.Id
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
