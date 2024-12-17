namespace HISApp.Domain
{
    public class City
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public virtual ICollection<Area> Areas{ get; set; }
    }
}
