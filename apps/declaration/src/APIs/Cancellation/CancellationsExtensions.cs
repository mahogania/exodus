using Statement.APIs.Dtos;
using Statement.Infrastructure.Models;

namespace Statement.APIs.Extensions;

public static class CancellationsExtensions
{
    public static Cancellation ToDto(this CancellationDbModel model)
    {
        return new Cancellation
        {
            AttachedFile = model.AttachedFile,
            CnclCn = model.CnclCn,
            CnclDgcnt = model.CnclDgcnt,
            CnclRqstDt = model.CnclRqstDt,
            CnclRsnCd = model.CnclRsnCd,
            CreatedAt = model.CreatedAt,
            DelOn = model.DelOn,
            FrstRegstId = model.FrstRegstId,
            FrstRgsrDttm = model.FrstRgsrDttm,
            Id = model.Id,
            LastChgDttm = model.LastChgDttm,
            LastChprId = model.LastChprId,
            LastOn = model.LastOn,
            PrcsSttsCd = model.PrcsSttsCd,
            ReffNo = model.ReffNo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CancellationDbModel ToModel(
        this CancellationUpdateInput updateDto,
        CancellationWhereUniqueInput uniqueId
    )
    {
        var cancellation = new CancellationDbModel
        {
            Id = uniqueId.Id,
            CnclCn = updateDto.CnclCn,
            CnclDgcnt = updateDto.CnclDgcnt,
            CnclRqstDt = updateDto.CnclRqstDt,
            CnclRsnCd = updateDto.CnclRsnCd,
            DelOn = updateDto.DelOn,
            FrstRegstId = updateDto.FrstRegstId,
            FrstRgsrDttm = updateDto.FrstRgsrDttm,
            LastChgDttm = updateDto.LastChgDttm,
            LastChprId = updateDto.LastChprId,
            LastOn = updateDto.LastOn,
            PrcsSttsCd = updateDto.PrcsSttsCd,
            ReffNo = updateDto.ReffNo
        };

        if (updateDto.AttachedFile != null)
        {
            cancellation.AttachedFile = updateDto.AttachedFile;
        }
        if (updateDto.CreatedAt != null)
        {
            cancellation.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            cancellation.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return cancellation;
    }
}
