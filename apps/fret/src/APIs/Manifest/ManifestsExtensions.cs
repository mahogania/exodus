using Fret.APIs.Dtos;
using Fret.Infrastructure.Models;

namespace Fret.APIs.Extensions;

public static class ManifestsExtensions
{
    public static Manifest ToDto(this ManifestDbModel model)
    {
        return new Manifest
        {
            AlBlGcnt = model.AlBlGcnt,
            AlCntrGcnt = model.AlCntrGcnt,
            AlEcntrCnt = model.AlEcntrCnt,
            AlNtwg = model.AlNtwg,
            AlPckgGcnt = model.AlPckgGcnt,
            AlTtwg = model.AlTtwg,
            AlVhclGcnt = model.AlVhclGcnt,
            ApreOnCd = model.ApreOnCd,
            ArvlDttm = model.ArvlDttm,
            AtchFileId = model.AtchFileId,
            AudtOpinCn = model.AudtOpinCn,
            CagDcshRgsrMgmtNo = model.CagDcshRgsrMgmtNo,
            CagRqstTpCd = model.CagRqstTpCd,
            CarrAddrNm = model.CarrAddrNm,
            CarrCd = model.CarrCd,
            CoRqstNo = model.CoRqstNo,
            CreatedAt = model.CreatedAt,
            DelOn = model.DelOn,
            DptrDttm = model.DptrDttm,
            DptrPortCd = model.DptrPortCd,
            DrvrNm = model.DrvrNm,
            EurFxrt = model.EurFxrt,
            FrstRegstId = model.FrstRegstId,
            FrstRgsrDttm = model.FrstRgsrDttm,
            Id = model.Id,
            ImoNo = model.ImoNo,
            JrsdOrgnCd = model.JrsdOrgnCd,
            LastChgDttm = model.LastChgDttm,
            LastChprId = model.LastChprId,
            LastLdunDt = model.LastLdunDt,
            LastThrgPortCd = model.LastThrgPortCd,
            LdunBlGcnt = model.LdunBlGcnt,
            LoadRqstNo = model.LoadRqstNo,
            LtspOn = model.LtspOn,
            Mrn = model.Mrn,
            PrcsDttm = model.PrcsDttm,
            PrcsSttsCd = model.PrcsSttsCd,
            RealArvlDttm = model.RealArvlDttm,
            ShipNttn = model.ShipNttn,
            ShipTtn = model.ShipTtn,
            TrnpMeanCd = model.TrnpMeanCd,
            TrnpMethIdfyNo = model.TrnpMethIdfyNo,
            TrnpMethLoctNm = model.TrnpMethLoctNm,
            TrnpMethNatCd = model.TrnpMethNatCd,
            TrnpMethNm = model.TrnpMethNm,
            TrnpMethRgsrDt = model.TrnpMethRgsrDt,
            TrnpRferNo = model.TrnpRferNo,
            TrsnCoCd = model.TrsnCoCd,
            TrsnDttm = model.TrsnDttm,
            UpdatedAt = model.UpdatedAt,
            UsdFxrt = model.UsdFxrt,
        };
    }

    public static ManifestDbModel ToModel(
        this ManifestUpdateInput updateDto,
        ManifestWhereUniqueInput uniqueId
    )
    {
        var manifest = new ManifestDbModel
        {
            Id = uniqueId.Id,
            AlBlGcnt = updateDto.AlBlGcnt,
            AlCntrGcnt = updateDto.AlCntrGcnt,
            AlEcntrCnt = updateDto.AlEcntrCnt,
            AlNtwg = updateDto.AlNtwg,
            AlPckgGcnt = updateDto.AlPckgGcnt,
            AlTtwg = updateDto.AlTtwg,
            AlVhclGcnt = updateDto.AlVhclGcnt,
            ApreOnCd = updateDto.ApreOnCd,
            ArvlDttm = updateDto.ArvlDttm,
            AtchFileId = updateDto.AtchFileId,
            AudtOpinCn = updateDto.AudtOpinCn,
            CagDcshRgsrMgmtNo = updateDto.CagDcshRgsrMgmtNo,
            CagRqstTpCd = updateDto.CagRqstTpCd,
            CarrAddrNm = updateDto.CarrAddrNm,
            CarrCd = updateDto.CarrCd,
            CoRqstNo = updateDto.CoRqstNo,
            DelOn = updateDto.DelOn,
            DptrDttm = updateDto.DptrDttm,
            DptrPortCd = updateDto.DptrPortCd,
            DrvrNm = updateDto.DrvrNm,
            EurFxrt = updateDto.EurFxrt,
            FrstRegstId = updateDto.FrstRegstId,
            FrstRgsrDttm = updateDto.FrstRgsrDttm,
            ImoNo = updateDto.ImoNo,
            JrsdOrgnCd = updateDto.JrsdOrgnCd,
            LastChgDttm = updateDto.LastChgDttm,
            LastChprId = updateDto.LastChprId,
            LastLdunDt = updateDto.LastLdunDt,
            LastThrgPortCd = updateDto.LastThrgPortCd,
            LdunBlGcnt = updateDto.LdunBlGcnt,
            LoadRqstNo = updateDto.LoadRqstNo,
            LtspOn = updateDto.LtspOn,
            Mrn = updateDto.Mrn,
            PrcsDttm = updateDto.PrcsDttm,
            PrcsSttsCd = updateDto.PrcsSttsCd,
            RealArvlDttm = updateDto.RealArvlDttm,
            ShipNttn = updateDto.ShipNttn,
            ShipTtn = updateDto.ShipTtn,
            TrnpMeanCd = updateDto.TrnpMeanCd,
            TrnpMethIdfyNo = updateDto.TrnpMethIdfyNo,
            TrnpMethLoctNm = updateDto.TrnpMethLoctNm,
            TrnpMethNatCd = updateDto.TrnpMethNatCd,
            TrnpMethNm = updateDto.TrnpMethNm,
            TrnpMethRgsrDt = updateDto.TrnpMethRgsrDt,
            TrnpRferNo = updateDto.TrnpRferNo,
            TrsnCoCd = updateDto.TrsnCoCd,
            TrsnDttm = updateDto.TrsnDttm,
            UsdFxrt = updateDto.UsdFxrt
        };

        if (updateDto.CreatedAt != null)
        {
            manifest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            manifest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return manifest;
    }
}
