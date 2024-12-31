namespace HISApp.DTOs;

public class OrderDTO
{
    public string RequestedBy { set; get; }
    public int QTY { get; set; }
    public string Note { set; get; }
    public string Name { set; get; }

    public int DrugId { get; set; }
}