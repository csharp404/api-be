using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace HISApp.Domain
{
    public class User:IdentityUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public DateTime? HireDate { get; set; }
        public bool? Gender { get; set; }
        [InverseProperty(nameof(Address.User))]
        [ForeignKey(nameof(AddressId))]
        public Guid? AddressId { set; get; }
        public Address? Address { get; set; }
        public string? Experience { get; set; }
        public int? DepartmentId { set; get; }
        public Department? Department { get; set; }
        public string? Specialization { get; set; }
        public string? ImagePath { get; set; }
        public string? ImageUrl { get; set; }
        public virtual ICollection<Patient>? Patients { get; set; }
    }
}
