namespace AdSystem.Models;
public class Annonsorer
{
	public int AnnonsorID { get; set; }	
	public required string Name { get; set; }
	public required string PhoneNumber { get; set; }
	public required string Address { get; set; }
	public required string ZipCode { get; set; }
	public required string City { get; set; }
	public bool IsCompany { get; set; }
	public string? OrganisationID { get; set; }
	public string? BillingAdress { get; set; }
	public string? BillingZipCode { get; set; }
	public string? BillingCity { get; set; }
	public int? SubscriptionID { get; set; }

}