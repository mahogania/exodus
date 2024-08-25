using Control.APIs.Common;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class GoodsAndWithReImportationInStateFindManyArgs
    : FindManyInput<
        GoodsAndWithReImportationInState,
        GoodsAndWithReImportationInStateWhereInput
    >
{
}
