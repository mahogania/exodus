using Evaluation.APIs.Common;
using Evaluation.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CommonFindManyArgs : FindManyInput<Common, CommonWhereInput> { }
