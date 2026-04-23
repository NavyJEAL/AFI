using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AdSystem.Services;
using AdSystem.Models;


namespace AdSystem.Controllers;

public class AdsController : Controller
{
	private readonly AppDbContext _context;
	private readonly WebApiClient _webApiClient;
	public AdsController(AppDbContext context, WebApiClient webApiClient)
	{
		_context = context;
		_webApiClient = webApiClient;
	}

	// List all ads
	[HttpGet]
	public async Task<IActionResult> AdsList()
	{
		var ads = await _context.Ads.ToListAsync();
		return View(ads);
	}

	// Form to create a new ad
	[HttpGet]
	public async Task<IActionResult> CreateAd()
	{
		return View();
	}

	// Handle form submission to create a new ad
	[HttpPost]
	public async Task<IActionResult> CreateAd(Ads ad)
	{
		if (ModelState.IsValid)
		{
			_context.Ads.Add(ad);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(AdsList));
		}
		return View(ad);
	}
	
	[HttpGet]
	public async Task<IActionResult> GetSubscriber(string subscriberID)
	{
		var subscriberInfo = await _webApiClient.GetSubscriberIDAsync(subscriberID);
		if (subscriberInfo == null)
		{
			return NotFound();
		}
		return View(subscriberInfo);
	}
}