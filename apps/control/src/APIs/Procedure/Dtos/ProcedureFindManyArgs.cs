using Control.APIs.Common;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs.Dtos;

[BindProperties(SupportsGet = true)]
<<<<<<<< HEAD:apps/control/APIs/DemandForRcoClre/Dtos/DemandForRcoClreFindManyArgs.cs
public class DemandForRcoClreFindManyArgs
    : FindManyInput<DemandForRcoClre, DemandForRcoClreWhereInput>
{
}
========
public class ProcedureFindManyArgs : FindManyInput<Procedure, ProcedureWhereInput> { }
>>>>>>>> 0254739 (Amplication build # cm09hhhxj3ubu13ggkuzn20y6):apps/control/src/APIs/Procedure/Dtos/ProcedureFindManyArgs.cs
