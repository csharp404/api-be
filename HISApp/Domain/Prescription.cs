namespace HISApp.Domain
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Medication { set; get; }
        public string Dosage { set; get; }
        public string Instructions { set; get; }
        public int PatientId { get; set; }
        public DateTime CreateAt { set; get; }= DateTime.Now;
       
        public virtual Patient? Patient { get; set; }
    }
}
