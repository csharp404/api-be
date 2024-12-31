using System.ComponentModel.DataAnnotations.Schema;

namespace HISApp.Domain;

public class Emergencies
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { set; get; }

    public int EmergencyCodeId { set; get; } 
    public EmergencyCode EmergencyCode { get; set; }
}