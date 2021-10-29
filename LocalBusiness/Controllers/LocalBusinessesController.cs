using LocalBusiness.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBusiness.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class LocalBusinessesController : ControllerBase
  {
    private readonly LocalBusinessContext _db;

    public LocalBusinessesController(LocalBusinessContext db)
    {
      _db = db;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);

      if (business == null)
      {
        return NotFound();
      }
      return business;
    }


    [HttpPost]
    public async Task<ActionResult<Business>> Post(Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, Business business)
    {
      if (id != business.BusinessId)
      {
        return BadRequest();
      }
      _db.Entry(business).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BusinessExists(id))
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

    [ApiExplorerSettings(IgnoreApi = true)]
    private bool BusinessExists(int id)
    {
      return _db.Businesses.Any(e => e.BusinessId == id);
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);
      if (business == null)
      {
        return NotFound();
      }

      _db.Businesses.Remove(business);
      await _db.SaveChangesAsync();
      return NoContent();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Business>>> Get(string name, string type, string genre, int price)
    {
      var query = _db.Businesses.AsQueryable();

      if (name != null)
      {
        query = query.Where(e => e.Name.ToLower() == name.ToLower());
      }

      if (type != null)
      {
        query = query.Where(e => e.Type.ToLower() == type.ToLower());
      }

      if (genre != null)
      {
        query = query.Where(e => e.Genre.ToLower() == genre.ToLower());
      }

      if (price != 0)
      {
        query = query.Where(e => e.Price == price);
      }

      return await query.ToListAsync();
    }
  }
}
