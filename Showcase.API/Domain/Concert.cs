namespace Showcase.API.Domain
{
	public class Concert : Event
	{
		public int ArtistId { get; set; }
		public int VenueId { get; set; }
		public virtual Artist Artist { get; set; } = null!;
		public virtual Venue Venue { get; set; } = null!;
		public virtual ICollection<UserConcert> UserConcerts { get; set; } = new List<UserConcert>();
	}
}
