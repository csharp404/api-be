namespace HISApp.DTOs;

public class VitalsignDto
{
    public int PatientId { set; get; }
    public int HeartRate { get; set; }
    public string BloodPressure { get; set; }
    public float Temperature { get; set; }
    public int Breaths { set; get; }

    public DateTime createdAt { set; get; } = DateTime.Now;
}