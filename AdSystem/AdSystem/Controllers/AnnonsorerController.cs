using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AdSystem.Services;
using AdSystem.Models;

namespace AdSystem.Controllers;

public class AnnonsorerController : Controller
{
	private readonly AppDbContext _context;
	private readonly WebApiClient _webApiClient;
	public AnnonsorerController(AppDbContext context, WebApiClient webApiClient)
	{
		_context = context;
		_webApiClient = webApiClient;
	}

}