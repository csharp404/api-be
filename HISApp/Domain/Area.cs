namespace HISApp.Domain
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { set; get; }
        public City City { set; get; }
    }
}
