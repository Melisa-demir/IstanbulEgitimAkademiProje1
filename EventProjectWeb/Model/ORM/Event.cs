using System.ComponentModel.DataAnnotations.Schema;

namespace EventProjectWeb.Model.ORM
{
    public class Event: BaseEntity
    {
        public string Name { get; set; }
        public string DetailedDescription { get; set; }
        public string? Address { get; set; }
        public string GoogleMapLink { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public int ArtistId { get; set; }
        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; }
        public int TicketId { get; set; }
        [ForeignKey("TickedId")]
        public Ticket Ticket { get; set; }
    }
}
