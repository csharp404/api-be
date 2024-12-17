namespace HISApp.Domain
{
    public class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QTY { set; get; }
        public DateTime ExpiryDate { set; get; }
    }
}
