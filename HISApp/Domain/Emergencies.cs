using System.ComponentModel.DataAnnotations.Schema;

namespace HISApp.Domain;

public class Emergencies
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { set; get; }

    public int EmergencyCodeId { set; get; } 

    public string NameOfUser { set; get; }
    public string DepartmentName { set; get; }
    public EmergencyCode EmergencyCode { get; set; }
}