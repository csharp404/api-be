namespace HISApp.DTOs;

public class DiagnosisCreateDTO
{
    public string? PatientName { get; set; }
    public string Symptoms { get; set; }
    public string Description { get; set; }
    public string Notes { get; set; }
    public DateTime? Created { get; set; } = DateTime.Now;
    public int PatientId { set; get; }
}