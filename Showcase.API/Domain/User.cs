namespace Showcase.API.Domain
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public virtual ICollection<UserConcert> UserConcerts { get; set; } = new List<UserConcert>();
	}
}
