using HISApp.Domain;

namespace HISApp.DTOs;

public class PatientsDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int DepartmentId { set; get; }
    public string PCD { set; get; }
    public int age { set; get; }
    public string phone { set; get; }
    public bool gender { set; get; }
    public string details { set; get; }
    public string BloodType { set; get; }
    public int AreaId { set; get; }
    public int cityId { set; get; }
    public string LegalGaurdainPhone { get; set; }
    public string LegalGaurdainName { get; set; }
}