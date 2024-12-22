using HISApp.ENums;

namespace HISApp.DTOs
{
    public class SignUpDTO
    {

        public string? id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? age { get; set; }
        public int? departmentid { get; set; }
        public DateTime hiredate { get; set; } = DateTime.Now;
        public string? experience { get; set; }
        public string? phonenumber { get; set; }
        public int? gender { get; set; }
        public string email { get; set; }
        public int? cityid { get; set; }
        public int? areaid { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int Role { get; set; }


    }
}
