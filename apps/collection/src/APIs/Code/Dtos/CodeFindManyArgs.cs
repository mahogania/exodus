using Collection.APIs.Common;
using Collection.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CodeFindManyArgs : FindManyInput<Code, CodeWhereInput> { }
