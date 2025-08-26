namespace Showcase.API.Domain
{
	public class Artist
	{
		public int Id { get; set; }
		public int SpotifyId { get; set; }
		public string Name { get; set; } = string.Empty;
		public string ImageUrl { get; set; } = string.Empty;
		public virtual ICollection<Concert> Concerts { get; set; } = new List<Concert>();
	}
}
