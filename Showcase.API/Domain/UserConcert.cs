namespace Showcase.API.Domain
{
	public class UserConcert
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int ConcertId { get; set; }
		public ConcertStatus Status { get; set; }
		public DateTime? ConcertDate { get; set; }
		public string? Notes { get; set; }
		public int? Rating { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public virtual User User { get; set; } = null!;
		public virtual Concert Concert { get; set; } = null!;
	}
	
	public enum ConcertStatus
	{
		Planned,
		Visited,
		Cancelled
	}
}
