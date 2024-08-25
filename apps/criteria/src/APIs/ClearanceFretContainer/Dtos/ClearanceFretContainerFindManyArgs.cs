using Criteria.APIs.Common;
using Criteria.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class ClearanceFretContainerFindManyArgs
    : FindManyInput<ClearanceFretContainer, ClearanceFretContainerWhereInput> { }
