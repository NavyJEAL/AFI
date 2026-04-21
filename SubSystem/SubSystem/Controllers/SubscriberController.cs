using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SubscriberController : ControllerBase
{
	private readonly AppDbContext _context;
	public SubscriberController(AppDbContext context)
	{
		_context = context;
	}

	// GET: api/Subscriber/5
	[HttpGet("{id}")]
	public async Task<ActionResult<Subscriber>> GetSubscriber(int id)
	{
		var subscriber = await _context.Subscribers.FindAsync(id);
		if (subscriber == null)
		{
			return NotFound();
		}
		return subscriber;
	}

}