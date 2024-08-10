using Collection.APIs.Common;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class OfficialReportFindManyArgs
    : FindManyInput<OfficialReport, OfficialReportWhereInput>
{
}
