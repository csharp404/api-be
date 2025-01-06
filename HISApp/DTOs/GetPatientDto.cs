namespace HISApp.DTOs;

public class GetPatientDto
{

    public int id { set; get; }
    public string name { get; set; }
        public string department { get; set; }
        public string pcd { get; set; }
        public string phoneNumber { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public DateTime admissionDate { get; set; }
        public string Code { set; get; }
        public string? cityName { set; get; }
        public string? AreaName { set; get; }


}