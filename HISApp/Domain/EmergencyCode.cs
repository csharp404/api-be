using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace HISApp.Domain;

public class EmergencyCode
{

    public int Id { set; get; }

    public string Title { set; get; }
    public string Color { set; get; }
    public string Description { set; get; }

    public string Code { set; get; }




}