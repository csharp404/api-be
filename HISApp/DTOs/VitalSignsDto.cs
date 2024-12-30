namespace HISApp.DTOs;

public class VitalSignsDto
{
    public int Id { set; get; }
    public float HeartRate { get; set; }
    public string BloodPressure { get; set; }
    public float Temperature { get; set; }
    public float Breaths { set; get; } 
    
    
    public float HeartRateAVG { get; set; }
    public float BloodPressureAVG { get; set; }
    public float TemperatureAVG { get; set; }
    public float BreathsAVG { set; get; }



    public DateTime DateRecorded { get; set; } = DateTime.Now;
}