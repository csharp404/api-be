using System.ComponentModel.DataAnnotations.Schema;

namespace HISApp.Domain
{
    public class HospitalVisit
    {
        public int  Id{ get; set; }
        public DateTime Addmission { get; set; }
        public DateTime Discharge { get; set; }
        
        public int DepartmentId { set; get; }
        public Department Department { set; get; }

        public int PatientId { get; set; }
        public Patient Patient { set; get; }

  

    }
}
