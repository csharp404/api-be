using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace HISApp.Domain
{
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public bool Gender { get; set; }

        public Guid AddressId { set; get; }
        public Address? Address { get; set; }

        public string LegalGaurdainPhone { get; set; }

        public string LegalGaurdainName { get; set; }

        public string BloodType { get; set; }

      

        public string PCD { set; get; }

        public bool IsDeleted { get; set; } = false;

        public virtual ICollection<HospitalVisit>? HospitalVisits { get; set; }

        public virtual ICollection<Prescription>? Prescriptions { get; set; } 

        public virtual ICollection<VitalSigns>? VitalSigns { get; set; }

        public virtual ICollection<Diagnosis>? Diagnoses{ get; set; }

        public virtual ICollection<SickLeave>? SickLeaves{ get; set; }

        
    }
}
