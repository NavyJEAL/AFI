using Microsoft.EntityFrameworkCore;
using SubSystem.Models;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	public DbSet<Subscriber> Subscribers { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Subscriber>(entity =>
		{
			entity.ToTable("tbl_subscribers");
			entity.Property(e => e.SubscriberID).HasColumnName("subs_subscriptionnumber");
			entity.Property(e => e.Personalnumber).HasColumnName("subs_personalnumber");
			entity.Property(e => e.FirstName).HasColumnName("subs_firstname");
			entity.Property(e => e.LastName).HasColumnName("subs_lastname");
			entity.Property(e => e.Address).HasColumnName("subs_address");
			entity.Property(e => e.ZipCode).HasColumnName("subs_zipcode");
			entity.Property(e => e.City).HasColumnName("subs_city");
			entity.Property(e => e.PhoneNumber).HasColumnName("subs_phone");
		});
	}
}