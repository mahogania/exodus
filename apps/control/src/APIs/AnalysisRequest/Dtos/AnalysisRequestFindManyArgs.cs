using Control.APIs.Common;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs.Dtos;

[BindProperties(SupportsGet = true)]
<<<<<<<< HEAD:apps/control/APIs/CommonRegimeRequest/Dtos/CommonRegimeRequestFindManyArgs.cs
public class CommonRegimeRequestFindManyArgs
    : FindManyInput<CommonRegimeRequest, CommonRegimeRequestWhereInput>
{
}
========
public class AnalysisRequestFindManyArgs
    : FindManyInput<AnalysisRequest, AnalysisRequestWhereInput> { }
>>>>>>>> 0254739 (Amplication build # cm09hhhxj3ubu13ggkuzn20y6):apps/control/src/APIs/AnalysisRequest/Dtos/AnalysisRequestFindManyArgs.cs
