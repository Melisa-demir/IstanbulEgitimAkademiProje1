namespace EventProjectWeb.Model.ORM
{
    public class Vanue :BaseEntity
    {
        public string VenueName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
    }
}
