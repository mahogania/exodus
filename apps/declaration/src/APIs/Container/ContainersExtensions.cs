using Statement.APIs.Dtos;
using Statement.Infrastructure.Models;

namespace Statement.APIs.Extensions;

public static class ContainersExtensions
{
    public static Container ToDto(this ContainerDbModel model)
    {
        return new Container
        {
            CntrNo = model.CntrNo,
            CntrSrno = model.CntrSrno,
            CntrStfnSttsCd = model.CntrStfnSttsCd,
            CntrTpCd = model.CntrTpCd,
            CreatedAt = model.CreatedAt,
            DelOn = model.DelOn,
            FrstRegstId = model.FrstRegstId,
            FrstRgsrDttm = model.FrstRgsrDttm,
            Id = model.Id,
            LastChgDttm = model.LastChgDttm,
            LastChprId = model.LastChprId,
            MdfyDgcnt = model.MdfyDgcnt,
            RefNo = model.RefNo,
            SealChpn1 = model.SealChpn1,
            SealChpn2 = model.SealChpn2,
            SealChpn3 = model.SealChpn3,
            SealChpnCd = model.SealChpnCd,
            SealNo1 = model.SealNo1,
            SealNo2 = model.SealNo2,
            SealNo3 = model.SealNo3,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ContainerDbModel ToModel(
        this ContainerUpdateInput updateDto,
        ContainerWhereUniqueInput uniqueId
    )
    {
        var container = new ContainerDbModel
        {
            Id = uniqueId.Id,
            CntrNo = updateDto.CntrNo,
            CntrSrno = updateDto.CntrSrno,
            CntrStfnSttsCd = updateDto.CntrStfnSttsCd,
            CntrTpCd = updateDto.CntrTpCd,
            DelOn = updateDto.DelOn,
            FrstRegstId = updateDto.FrstRegstId,
            FrstRgsrDttm = updateDto.FrstRgsrDttm,
            LastChgDttm = updateDto.LastChgDttm,
            LastChprId = updateDto.LastChprId,
            MdfyDgcnt = updateDto.MdfyDgcnt,
            RefNo = updateDto.RefNo,
            SealChpn1 = updateDto.SealChpn1,
            SealChpn2 = updateDto.SealChpn2,
            SealChpn3 = updateDto.SealChpn3,
            SealChpnCd = updateDto.SealChpnCd,
            SealNo1 = updateDto.SealNo1,
            SealNo2 = updateDto.SealNo2,
            SealNo3 = updateDto.SealNo3
        };

        if (updateDto.CreatedAt != null)
        {
            container.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            container.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return container;
    }
}
