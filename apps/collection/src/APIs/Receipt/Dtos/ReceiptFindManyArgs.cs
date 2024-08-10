using Collection.APIs.Common;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class ReceiptFindManyArgs : FindManyInput<Receipt, ReceiptWhereInput>
{
}
