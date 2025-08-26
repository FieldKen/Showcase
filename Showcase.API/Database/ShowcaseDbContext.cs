using Microsoft.EntityFrameworkCore;
using Showcase.API.Domain;

namespace Showcase.API.Database
{
	public class ShowcaseDbContext : DbContext
	{
		public ShowcaseDbContext(DbContextOptions<ShowcaseDbContext> options) : base(options)
		{
		}

		public DbSet<Artist> Artists { get; set; }
		public DbSet<Concert> Concerts { get; set; }
		public DbSet<Event> Events { get; set; }
		public DbSet<Festival> Festivals { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Performance> Performances { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<UserConcert> UserConcerts { get; set; }
		public DbSet<Venue> Venues { get; set; }

		protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
		{
			base.ConfigureConventions(configurationBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Artist>();

			modelBuilder.Entity<Concert>(entity =>
			{
				entity.HasOne(c => c.Artist)
					.WithMany(a => a.Concerts)
					.HasForeignKey(c => c.ArtistId)
					.OnDelete(DeleteBehavior.Restrict);
					
				entity.HasOne(c => c.Venue)
					.WithMany()
					.HasForeignKey(c => c.VenueId)
					.OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<Event>()
				.HasDiscriminator<string>("EventType")
				.HasValue<Festival>("Festival")
				.HasValue<Concert>("Concert");

			modelBuilder.Entity<Festival>(entity =>
			{
				entity.HasOne(f => f.Location)
					.WithMany()
					.HasForeignKey(f => f.LocationId)
					.OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<Location>();

			modelBuilder.Entity<Performance>(entity =>
			{
				entity.HasOne(p => p.Event)
					.WithMany(e => e.Performances)
					.HasForeignKey(p => p.EventId)
					.OnDelete(DeleteBehavior.Cascade);

				entity.HasOne(p => p.Artist)
					.WithMany()
					.HasForeignKey(p => p.ArtistId)
					.OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<User>();

			modelBuilder.Entity<UserConcert>(entity =>
			{
				entity.HasOne(uc => uc.User)
					.WithMany(u => u.UserConcerts)
					.HasForeignKey(uc => uc.UserId)
					.OnDelete(DeleteBehavior.Cascade);
					
				entity.HasOne(uc => uc.Concert)
					.WithMany(c => c.UserConcerts)
					.HasForeignKey(uc => uc.ConcertId)
					.OnDelete(DeleteBehavior.Cascade);
			});

			modelBuilder.Entity<Venue>(entity =>
			{
				entity.HasOne(v => v.Location)
					.WithMany()
					.HasForeignKey(v => v.LocationId)
					.OnDelete(DeleteBehavior.Restrict);
			});
		}
	}
}
