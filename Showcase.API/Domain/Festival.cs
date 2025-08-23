namespace Showcase.API.Domain
{
	public class Festival : Event
	{
		public DateTime EndDate { get; set; }
		public int LocationId { get; set; }
		public virtual Location Location { get; set; } = null!;
	}
}
