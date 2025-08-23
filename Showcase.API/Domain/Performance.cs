namespace Showcase.API.Domain
{
	public class Performance
	{
		public int Id { get; set; }
		public int EventId { get; set; }
		public virtual Event Event { get; set; } = null!;
		public int ArtistId { get; set; }
		public virtual Artist Artist { get; set; } = null!;
		public DateTime StartTime { get; set; }
		public int DurationMinutes { get; set; }
	}
}
