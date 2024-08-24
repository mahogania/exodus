namespace Control.APIs.Dtos;

public class CommonActiveGoodsRequestUpdateInput
{
    public DateTime? CreatedAt { get; set; }

    public List<string>? Details { get; set; }

    public string? Id { get; set; }

    public string? Journal { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
