using Microsoft.EntityFrameworkCore;
using AdSystem.Models;
public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}
	public DbSet<Annonsorer> Annonsorer { get; set; }
	public DbSet<Ads> Ads { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Annonsorer>(entity =>
		{
			entity.ToTable("tbl_annonsorer");
			entity.Property(e => e.AnnonsorID).HasColumnName("annonsor_id");
			entity.Property(e => e.Name).HasColumnName("annonsor_name");
			entity.Property(e => e.PhoneNumber).HasColumnName("annonsor_phone");
			entity.Property(e => e.Address).HasColumnName("annonsor_address");
			entity.Property(e => e.ZipCode).HasColumnName("annonsor_zipcode");
			entity.Property(e => e.City).HasColumnName("annonsor_city");
			entity.Property(e => e.IsCompany).HasColumnName("annonsor_iscompany");
			entity.Property(e => e.OrganisationID).HasColumnName("annonsor_organisationid");
			entity.Property(e => e.BillingAdress).HasColumnName("annonsor_billingaddress");
			entity.Property(e => e.BillingZipCode).HasColumnName("annonsor_billingzipcode");
			entity.Property(e => e.BillingCity).HasColumnName("annonsor_billingcity");
			entity.Property(e => e.SubscriptionID).HasColumnName("annonsor_subscriptionid");
		});

		modelBuilder.Entity<Ads>(entity =>
		{
			entity.ToTable("tbl_ads");
			entity.Property(e => e.AdID).HasColumnName("ad_id");
			entity.Property(e => e.Title).HasColumnName("ad_title");
			entity.Property(e => e.Content).HasColumnName("ad_content");
			entity.Property(e => e.ItemPrice).HasColumnName("ad_itemprice");
			entity.Property(e => e.AdPrice).HasColumnName("ad_adprice");
			entity.Property(e => e.AnnonsorerID).HasColumnName("ad_annonsorerid");

		});
	}
}