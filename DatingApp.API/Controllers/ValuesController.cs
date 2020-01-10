using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        public readonly DataContext context;
        public ValuesController(DataContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await context.Values.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var values = await context.Values.FirstOrDefaultAsync(c => c.Id == id);

            if (values == null)
            {
                return NotFound();
            }
            return Ok(values);
        }
    }
}