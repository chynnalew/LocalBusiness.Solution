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
  }
}
