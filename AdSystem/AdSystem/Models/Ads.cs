public class Ads
{
	public int AdID { get; set; }
	public required string Title { get; set; }
	public required string Content { get; set; }
	public required int ItemPrice { get; set; }
	public required int AdPrice { get; set; }
	public int AnnonsorerID { get; set; }
}