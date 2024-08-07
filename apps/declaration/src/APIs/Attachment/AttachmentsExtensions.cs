using Statement.APIs.Dtos;
using Statement.Infrastructure.Models;

namespace Statement.APIs.Extensions;

public static class AttachmentsExtensions
{
    public static Attachment ToDto(this AttachmentDbModel model)
    {
        return new Attachment
        {
            AtchDocSrno = model.AtchDocSrno,
            AtchFileId = model.AtchFileId,
            AtchFileNm = model.AtchFileNm,
            CreatedAt = model.CreatedAt,
            DelOn = model.DelOn,
            DocDesc = model.DocDesc,
            DocKndCd = model.DocKndCd,
            DocNo = model.DocNo,
            FrstRegstId = model.FrstRegstId,
            FrstRgsrDttm = model.FrstRgsrDttm,
            Id = model.Id,
            LastChgDttm = model.LastChgDttm,
            LastChprId = model.LastChprId,
            MdfyDgcnt = model.MdfyDgcnt,
            PblsDt = model.PblsDt,
            PblsIttNm = model.PblsIttNm,
            PdlsNo = model.PdlsNo,
            ReffNo = model.ReffNo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static AttachmentDbModel ToModel(
        this AttachmentUpdateInput updateDto,
        AttachmentWhereUniqueInput uniqueId
    )
    {
        var attachment = new AttachmentDbModel
        {
            Id = uniqueId.Id,
            AtchDocSrno = updateDto.AtchDocSrno,
            AtchFileId = updateDto.AtchFileId,
            AtchFileNm = updateDto.AtchFileNm,
            DelOn = updateDto.DelOn,
            DocDesc = updateDto.DocDesc,
            DocKndCd = updateDto.DocKndCd,
            DocNo = updateDto.DocNo,
            FrstRegstId = updateDto.FrstRegstId,
            FrstRgsrDttm = updateDto.FrstRgsrDttm,
            LastChgDttm = updateDto.LastChgDttm,
            LastChprId = updateDto.LastChprId,
            MdfyDgcnt = updateDto.MdfyDgcnt,
            PblsDt = updateDto.PblsDt,
            PblsIttNm = updateDto.PblsIttNm,
            PdlsNo = updateDto.PdlsNo,
            ReffNo = updateDto.ReffNo
        };

        if (updateDto.CreatedAt != null)
        {
            attachment.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            attachment.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return attachment;
    }
}
