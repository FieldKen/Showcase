namespace Showcase.API.Domain
{
	public class Concert : Event
	{
		public int VenueId { get; set; }
		public virtual Venue Venue { get; set; } = null!;
	}
}
