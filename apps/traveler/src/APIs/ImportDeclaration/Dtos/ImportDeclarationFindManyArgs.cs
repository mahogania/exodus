using Microsoft.AspNetCore.Mvc;
using Traveler.APIs.Common;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class ImportDeclarationFindManyArgs
    : FindManyInput<ImportDeclaration, ImportDeclarationWhereInput> { }
