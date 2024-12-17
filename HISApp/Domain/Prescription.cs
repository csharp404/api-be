namespace HISApp.Domain
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Medication { set; get; }
        public string Dosage { set; get; }
        public string Instructions { set; get; }
        public DateTime CreateAt { set; get; }= DateTime.Now;
        public  int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
