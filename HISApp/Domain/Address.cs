using System.ComponentModel.DataAnnotations.Schema;

namespace HISApp.Domain
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { set; get; }= Guid.NewGuid();
        public int? CityId {set; get; }
        public int? AreaId { set; get; }
        [InverseProperty(nameof(User.Id))]
        [ForeignKey(nameof(UserId))]
        public string? UserId  { set; get; } 
        public User? User { set; get; }
    }
}
