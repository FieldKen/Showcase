namespace Showcase.API.Domain
{
	public abstract class Event
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public DateTime StartDate { get; set; }
		public EventStatus Status { get; set; } = EventStatus.Planning;
		public virtual ICollection<Performance> Performances { get; set; } = new List<Performance>();
	}

	public enum EventStatus
	{
		Planning,
		Going,
		Went,
		Maybe
	}
}
