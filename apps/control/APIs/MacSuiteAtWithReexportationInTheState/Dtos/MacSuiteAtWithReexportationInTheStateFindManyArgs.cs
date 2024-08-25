using Control.APIs.Common;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class MacSuiteAtWithReexportationInTheStateFindManyArgs
    : FindManyInput<
        MacSuiteAtWithReexportationInTheState,
        MacSuiteAtWithReexportationInTheStateWhereInput
    >
{
}
