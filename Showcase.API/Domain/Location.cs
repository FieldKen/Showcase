namespace Showcase.API.Domain
{
	public class Location
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;
		public string? PostalCode { get; set; }
		public double? Latitude { get; set; }
		public double? Longitude { get; set; }
	}
}
