using Clre.APIs.Common;
using Clre.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class AtAndStandardExchangeFindManyArgs
    : FindManyInput<AtAndStandardExchange, AtAndStandardExchangeWhereInput> { }
