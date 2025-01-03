using HISApp.Domain;

namespace HISApp.DTOs;

public class prescriptionDTO
{
    public string Medication { set; get; }
    public string Dosage { set; get; }
    public string Instructions { set; get; }
    public int PatientId { get; set; }

    public string? PatientName { set; get; }

    public DateTime CreatedAt { set; get; } = DateTime.Now;
}