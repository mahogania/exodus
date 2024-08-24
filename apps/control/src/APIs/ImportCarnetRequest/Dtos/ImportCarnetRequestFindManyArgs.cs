using Control.APIs.Common;
using Control.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class ImportCarnetRequestFindManyArgs
    : FindManyInput<ImportCarnetRequest, ImportCarnetRequestWhereInput> { }
