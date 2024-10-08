using Code.APIs.Common;
using Code.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class ArticlePaysBeneficiaireAntiDumpingFindManyArgs
    : FindManyInput<
        ArticlePaysBeneficiaireAntiDumping,
        ArticlePaysBeneficiaireAntiDumpingWhereInput
    > { }
