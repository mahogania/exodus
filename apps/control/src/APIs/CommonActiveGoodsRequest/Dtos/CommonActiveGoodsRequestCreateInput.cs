namespace Control.APIs.Dtos;

public class CommonActiveGoodsRequestCreateInput
{
    public DateTime CreatedAt { get; set; }

    public List<DetailOfActiveGoods>? Details { get; set; }

    public string? Id { get; set; }

    public Procedure? Journal { get; set; }

    public DateTime UpdatedAt { get; set; }
}
