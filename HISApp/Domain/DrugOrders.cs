namespace HISApp.Domain;

public class DrugOrders
{
    public int Id { get; set; }
    public  string RequestedBy { set;get; } 
    public int QTY{ get; set; }
    public string Name{ get; set; }
    public int Status { set; get; } = 2;//1 fulfilment , 2 pending , 3 REJECT
    public string Note { set; get; }
    public virtual  Drug Drug { set; get; }
}