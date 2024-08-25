using Code.APIs.Common;
using Code.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class ShAnalyseCollectionTemporaire2FindManyArgs
    : FindManyInput<ShAnalyseCollectionTemporaire2, ShAnalyseCollectionTemporaire2WhereInput> { }
