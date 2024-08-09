using Microsoft.AspNetCore.Mvc;
using Statement.APIs.Common;
using Statement.Infrastructure.Models;

namespace Statement.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class OperatorFindManyArgs : FindManyInput<Operator, OperatorWhereInput> { }
