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

	// GET: api/Subscriber/(id) - Hämta en prenumerant baserat på ID
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

	// POST: Skapar en ny prenumerant
	[HttpPost]
	public async Task<ActionResult<Subscriber>> CreateSubscriber(Subscriber subscriber)
	{
		_context.Subscribers.Add(subscriber);
		await _context.SaveChangesAsync();
		return CreatedAtAction(nameof(GetSubscriber), new { id = subscriber.SubscriberID }, subscriber);
	}

	// PUT: api/Subscriber/(id) - Update existing subscriber
	[HttpPut("{id}")]
	public async Task<IActionResult> UpdateSubscriber(int id, Subscriber subscriber)
	{
		if (id != subscriber.SubscriberID)
		{
			return BadRequest();
		}

		_context.Entry(subscriber).State = EntityState.Modified;
		await _context.SaveChangesAsync();

		return NoContent();
	}

	// DELETE: Raderar en prenumerant baserat på ID
	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteSubscriber(int id)
	{
		var subscriber = await _context.Subscribers.FindAsync(id);
		if (subscriber == null)
		{
			return NotFound();
		}

		_context.Subscribers.Remove(subscriber);
		await _context.SaveChangesAsync();

		return NoContent();
	}

}