using Code.APIs.Common;
using Code.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class ShAnalyseCollectionTemporaire3FindManyArgs
    : FindManyInput<ShAnalyseCollectionTemporaire3, ShAnalyseCollectionTemporaire3WhereInput> { }
