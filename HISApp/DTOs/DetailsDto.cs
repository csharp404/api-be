namespace HISApp.DTOs
{
    public class DetailsDto
    {
        public string? id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? age { get; set; }
        public int? departmentid { get; set; }
        public string? departmentName { get; set; }
        public string? hiredate { get; set; } = DateTime.Now.ToShortDateString();
        public string? experience { get; set; }
        public string? phonenumber { get; set; }
        public bool? gender { get; set; }
        public string email { get; set; }
        public int? cityid { get; set; }
        public int? areaid { get; set; }
        public int Role { get; set; }




    }
}
