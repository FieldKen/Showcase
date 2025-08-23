namespace Showcase.API.Domain
{
	public class Venue
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Capacity { get; set; }
		public int LocationId { get; set; }
		public virtual Location Location { get; set; } = null!;
	}
}
