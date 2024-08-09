using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Fret.APIs.Extensions;
using Fret.Infrastructure;
using Fret.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Fret.APIs;

public abstract class ManifestsServiceBase : IManifestsService
{
    protected readonly FretDbContext _context;

    public ManifestsServiceBase(FretDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Manifeste
    /// </summary>
    public async Task<Manifest> CreateManifest(ManifestCreateInput createDto)
    {
        var manifest = new ManifestDbModel
        {
            AlBlGcnt = createDto.AlBlGcnt,
            AlCntrGcnt = createDto.AlCntrGcnt,
            AlEcntrCnt = createDto.AlEcntrCnt,
            AlNtwg = createDto.AlNtwg,
            AlPckgGcnt = createDto.AlPckgGcnt,
            AlTtwg = createDto.AlTtwg,
            AlVhclGcnt = createDto.AlVhclGcnt,
            ApreOnCd = createDto.ApreOnCd,
            ArvlDttm = createDto.ArvlDttm,
            AtchFileId = createDto.AtchFileId,
            AudtOpinCn = createDto.AudtOpinCn,
            CagDcshRgsrMgmtNo = createDto.CagDcshRgsrMgmtNo,
            CagRqstTpCd = createDto.CagRqstTpCd,
            CarrAddrNm = createDto.CarrAddrNm,
            CarrCd = createDto.CarrCd,
            CoRqstNo = createDto.CoRqstNo,
            CreatedAt = createDto.CreatedAt,
            DelOn = createDto.DelOn,
            DptrDttm = createDto.DptrDttm,
            DptrPortCd = createDto.DptrPortCd,
            DrvrNm = createDto.DrvrNm,
            EurFxrt = createDto.EurFxrt,
            FrstRegstId = createDto.FrstRegstId,
            FrstRgsrDttm = createDto.FrstRgsrDttm,
            ImoNo = createDto.ImoNo,
            JrsdOrgnCd = createDto.JrsdOrgnCd,
            LastChgDttm = createDto.LastChgDttm,
            LastChprId = createDto.LastChprId,
            LastLdunDt = createDto.LastLdunDt,
            LastThrgPortCd = createDto.LastThrgPortCd,
            LdunBlGcnt = createDto.LdunBlGcnt,
            LoadRqstNo = createDto.LoadRqstNo,
            LtspOn = createDto.LtspOn,
            Mrn = createDto.Mrn,
            PrcsDttm = createDto.PrcsDttm,
            PrcsSttsCd = createDto.PrcsSttsCd,
            RealArvlDttm = createDto.RealArvlDttm,
            ShipNttn = createDto.ShipNttn,
            ShipTtn = createDto.ShipTtn,
            TrnpMeanCd = createDto.TrnpMeanCd,
            TrnpMethIdfyNo = createDto.TrnpMethIdfyNo,
            TrnpMethLoctNm = createDto.TrnpMethLoctNm,
            TrnpMethNatCd = createDto.TrnpMethNatCd,
            TrnpMethNm = createDto.TrnpMethNm,
            TrnpMethRgsrDt = createDto.TrnpMethRgsrDt,
            TrnpRferNo = createDto.TrnpRferNo,
            TrsnCoCd = createDto.TrsnCoCd,
            TrsnDttm = createDto.TrsnDttm,
            UpdatedAt = createDto.UpdatedAt,
            UsdFxrt = createDto.UsdFxrt
        };

        if (createDto.Id != null)
        {
            manifest.Id = createDto.Id;
        }

        _context.Manifests.Add(manifest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ManifestDbModel>(manifest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Manifeste
    /// </summary>
    public async Task DeleteManifest(ManifestWhereUniqueInput uniqueId)
    {
        var manifest = await _context.Manifests.FindAsync(uniqueId.Id);
        if (manifest == null)
        {
            throw new NotFoundException();
        }

        _context.Manifests.Remove(manifest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Manifests
    /// </summary>
    public async Task<List<Manifest>> Manifests(ManifestFindManyArgs findManyArgs)
    {
        var manifests = await _context
            .Manifests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return manifests.ConvertAll(manifest => manifest.ToDto());
    }

    /// <summary>
    /// Meta data about Manifeste records
    /// </summary>
    public async Task<MetadataDto> ManifestsMeta(ManifestFindManyArgs findManyArgs)
    {
        var count = await _context.Manifests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Manifeste
    /// </summary>
    public async Task<Manifest> Manifest(ManifestWhereUniqueInput uniqueId)
    {
        var manifests = await this.Manifests(
            new ManifestFindManyArgs { Where = new ManifestWhereInput { Id = uniqueId.Id } }
        );
        var manifest = manifests.FirstOrDefault();
        if (manifest == null)
        {
            throw new NotFoundException();
        }

        return manifest;
    }

    /// <summary>
    /// Update one Manifeste
    /// </summary>
    public async Task UpdateManifest(
        ManifestWhereUniqueInput uniqueId,
        ManifestUpdateInput updateDto
    )
    {
        var manifest = updateDto.ToModel(uniqueId);

        _context.Entry(manifest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Manifests.Any(e => e.Id == manifest.Id))
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
