using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;


namespace TravelApi.Controllers.v1
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]
  public class ReviewsController : ControllerBase
  {
    private readonly TravelApiContext _db;
    public ReviewsController(TravelApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Review>>> Get(string country, string city, bool sortByRating, bool sortByDescriptionCount)
    {
      IQueryable<Review> query = _db.Reviews.AsQueryable();

      // 5001/api/reviews?country=mexico
      if (country != null)
      {
        query = query.Where(review => review.Country == country);
      }

      // 5001/api/reviews?country=florence
      if (city != null)
      {
        query = query.Where(review => review.City == city);
      }

      // 5001/api/reviews?sortByRating=true
      if (sortByRating == true)
      {
        query = query.OrderByDescending(review => review.Rating);
      }

      // 5001/api/reviews?sortByDescriptionCount=true
      if (sortByDescriptionCount == true)
      {
        IEnumerable<Review> enumeableQuery = _db.Reviews.ToList(); 
        foreach (Review review in enumeableQuery)
        {
          review.DescriptionCount = query.Where(entry => entry.City == review.City).Count();
          _db.SaveChanges();
        }
        // Order by city & country
        query = query.OrderByDescending(review => review.DescriptionCount);
      }
      
      return await query.ToListAsync();
    }


    [HttpPost]
    public async Task<ActionResult<Review>> Post(Review review)
    {
      _db.Reviews.Add(review);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(Get), new { id = review.ReviewId }, review);
    }

    //5001/api/reviews/{id}
    // 5001/api/reviews/{}?userName=Henry
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Review review, string userName)
    {
      
      if (id != review.ReviewId)
      {
        return BadRequest();
      }
      if (userName != review.Author)
      {
        return BadRequest();
      }
      _db.Reviews.Update(review);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ReviewExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool ReviewExists(int id)
    {
      return _db.Reviews.Any(e => e.ReviewId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteReview(int id, string userName)
    {
      Review review = await _db.Reviews.FindAsync(id);
      if (review == null)
      {
        return NotFound();
      }
      
      if (userName != review.Author)
      {
        return BadRequest();
      }

      _db.Reviews.Remove(review);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    
    
  }
}