namespace HISApp.DTOs;

public class SickLeaveDto
{
    public string duration { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public string reason { get; set; }
    public int PatientId { set; get; }

    public DateTime CreatedAt { set; get; }
}