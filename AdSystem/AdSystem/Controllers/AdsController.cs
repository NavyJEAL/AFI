using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using AdSystem.Models;
using AdSystem.ViewModels;

namespace AdSystem.Controllers;

public class AdsController : Controller
{
	private readonly AppDbContext _context;
	private readonly HttpClient _httpClient;
	public AdsController(AppDbContext context, HttpClient httpClient)
	{
		_context = context;
		_httpClient = httpClient;
	}

}
