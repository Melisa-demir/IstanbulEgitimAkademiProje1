namespace EventProjectWeb.Model.ORM
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime DeleteDate { get; set; }
    }
}
