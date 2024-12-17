namespace HISApp.Domain
{
    public class VitalSigns
    {
        public int Id { set; get; }
        public int HeartRate { get; set; }
        public string BloodPressure { get; set; }
        public float Temperature { get; set; }
        public int Breaths { set; get; }
        public DateTime DateRecorded { get; set; }= DateTime.Now;
        public int PatientId { set; get; }
        public Patient? Patient { set; get; }
    }
}
