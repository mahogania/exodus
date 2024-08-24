namespace Control.APIs.Dtos;

public class CommonActiveGoodsRequestWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public List<string>? Details { get; set; }

    public string? Id { get; set; }

    public string? Journal { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
