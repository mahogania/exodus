using Statement.APIs.Dtos;
using Statement.Infrastructure.Models;

namespace Statement.APIs.Extensions;

public static class OperatorsExtensions
{
    public static Operator ToDto(this OperatorDbModel model)
    {
        return new Operator
        {
            CreatedAt = model.CreatedAt,
            DcerAddr = model.DcerAddr,
            DcerCoNm = model.DcerCoNm,
            DelOn = model.DelOn,
            ExppnAddr = model.ExppnAddr,
            ExppnCoNm = model.ExppnCoNm,
            ExppnEml = model.ExppnEml,
            FrstRegstId = model.FrstRegstId,
            FrstRgsrDttm = model.FrstRgsrDttm,
            Id = model.Id,
            ImppnAddr = model.ImppnAddr,
            ImppnCoNm = model.ImppnCoNm,
            LastChgDttm = model.LastChgDttm,
            LastChprId = model.LastChprId,
            MdfyDgcnt = model.MdfyDgcnt,
            ReffNo = model.ReffNo,
            TxprAddr = model.TxprAddr,
            TxprCoNm = model.TxprCoNm,
            TxprEml = model.TxprEml,
            TxprTlphNo = model.TxprTlphNo,
            UpdatedAt = model.UpdatedAt,

        };
    }

    public static OperatorDbModel ToModel(this OperatorUpdateInput updateDto, OperatorWhereUniqueInput uniqueId)
    {
        var operator = new OperatorDbModel
        {
            Id = uniqueId.Id,
            DcerAddr = updateDto.DcerAddr,
            DcerCoNm = updateDto.DcerCoNm,
            DelOn = updateDto.DelOn,
            ExppnAddr = updateDto.ExppnAddr,
            ExppnCoNm = updateDto.ExppnCoNm,
            ExppnEml = updateDto.ExppnEml,
            FrstRegstId = updateDto.FrstRegstId,
            FrstRgsrDttm = updateDto.FrstRgsrDttm,
            ImppnAddr = updateDto.ImppnAddr,
            ImppnCoNm = updateDto.ImppnCoNm,
            LastChgDttm = updateDto.LastChgDttm,
            LastChprId = updateDto.LastChprId,
            MdfyDgcnt = updateDto.MdfyDgcnt,
            ReffNo = updateDto.ReffNo,
            TxprAddr = updateDto.TxprAddr,
            TxprCoNm = updateDto.TxprCoNm,
            TxprEml = updateDto.TxprEml,
            TxprTlphNo = updateDto.TxprTlphNo
        };

        if (updateDto.CreatedAt != null)
        {
     operator.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
     operator.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return operator;
    }

}
