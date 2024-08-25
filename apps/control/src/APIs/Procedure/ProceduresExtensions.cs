using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ProceduresExtensions
{
    public static Procedure ToDto(this ProcedureDbModel model)
    {
        return new Procedure
        {
            AnalysisRequests = model.AnalysisRequests?.Select(x => x.Id).ToList(),
            CancellationRequests = model.CancellationRequests?.Select(x => x.Id).ToList(),
            CommonActiveGoodsRequests = model.CommonActiveGoodsRequests?.Select(x => x.Id).ToList(),
            CommonDetailedDeclaration = model.CommonDetailedDeclarationId,
            CommonExpressClearances = model.CommonExpressClearances?.Select(x => x.Id).ToList(),
            CommonOriginCertificateRequests = model
                .CommonOriginCertificateRequests?.Select(x => x.Id)
                .ToList(),
            CommonRegimeRequests = model.CommonRegimeRequests?.Select(x => x.Id).ToList(),
            CreatedAt = model.CreatedAt,
            ForeignOperatorRequests = model.ForeignOperatorRequests?.Select(x => x.Id).ToList(),
            Id = model.Id,
            PostalGoodsClearances = model.PostalGoodsClearances?.Select(x => x.Id).ToList(),
            PostalParcelSimplifiedClearances = model
                .PostalParcelSimplifiedClearances?.Select(x => x.Id)
                .ToList(),
            RecourseRequests = model.RecourseRequests?.Select(x => x.Id).ToList(),
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ProcedureDbModel ToModel(
        this ProcedureUpdateInput updateDto,
        ProcedureWhereUniqueInput uniqueId
    )
    {
        var procedure = new ProcedureDbModel { Id = uniqueId.Id };

        if (updateDto.CommonDetailedDeclaration != null)
        {
            procedure.CommonDetailedDeclarationId = updateDto.CommonDetailedDeclaration;
        }
        if (updateDto.CreatedAt != null)
        {
            procedure.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            procedure.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return procedure;
    }
}
