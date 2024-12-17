namespace HISApp.Domain;

public class SickLeave
{
    public int Id{ get; set; }
    public string duration{ get; set; }
    public DateTime ? start { get; set; }
    public DateTime? end { get; set; }
    public string Reason { get; set; }
    public int PatientId { set; get; }
    public Patient Patient { get; set; }
}