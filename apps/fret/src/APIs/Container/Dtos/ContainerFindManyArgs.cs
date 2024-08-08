using Fret.APIs.Common;
using Fret.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class ContainerFindManyArgs : FindManyInput<Container, ContainerWhereInput> { }
