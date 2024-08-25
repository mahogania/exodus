using Control.APIs.Common;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs.Dtos;

[BindProperties(SupportsGet = true)]
<<<<<<<< HEAD:apps/control/APIs/RequestForRecourse/Dtos/RequestForRecourseFindManyArgs.cs
public class RequestForRecourseFindManyArgs
    : FindManyInput<RequestForRecourse, RequestForRecourseWhereInput>
{
}
========
public class SampleRequestFindManyArgs : FindManyInput<SampleRequest, SampleRequestWhereInput> { }
>>>>>>>> 0254739 (Amplication build # cm09hhhxj3ubu13ggkuzn20y6):apps/control/src/APIs/SampleRequest/Dtos/SampleRequestFindManyArgs.cs
