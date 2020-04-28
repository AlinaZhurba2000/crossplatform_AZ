using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AZ_BackEnd.Models;

namespace AZ_BackEnd.Controllers
{
    [Route("api/[controller]")]
    
    //атрибут указывает, что контроллер отвечает на запросы веб-апи
    [ApiController]
    public class mudPumpsController : ControllerBase
    {
        private readonly mudPumpContext _context;

        public mudPumpsController(mudPumpContext context)
        {
            _context = context;
        }

        // GET: api/mudPumps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<mudPump>>> GetmudPumps()
        {
            return await _context.mudPumps.ToListAsync();
        }

        // GET: api/mudPumps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<mudPump>> GetmudPump(int id)
        {
            var mudPump = await _context.mudPumps.FindAsync(id);

            if (mudPump == null)
            {
                return NotFound();
            }

            return mudPump;
        }

   


        // PUT: api/mudPumps/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutmudPump(int id, mudPump mudPump)
        {
            if (id != mudPump.id)
            {
                return BadRequest();
            }

            _context.Entry(mudPump).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!mudPumpExists(id))
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

        // POST: api/mudPumps
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.


        [HttpPost]
        //этот метод получает значения элемента из списка буровых насосов из текста http запроса
        public async Task<ActionResult<mudPump>> PostmudPump(mudPump mudPump)
        {
            _context.mudPumps.Add(mudPump);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetmudPump", new { id = mudPump.ID }, mudPump);
            return CreatedAtAction(nameof(GetmudPump), new { id = mudPump.id }, mudPump);
        }

        // DELETE: api/mudPumps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<mudPump>> DeletemudPump(int id)
        {
            var mudPump = await _context.mudPumps.FindAsync(id);
            if (mudPump == null)
            {
                return NotFound();
            }

            _context.mudPumps.Remove(mudPump);
            await _context.SaveChangesAsync();

            return mudPump;
        }

        private bool mudPumpExists(int id)
        {
            return _context.mudPumps.Any(e => e.id == id);
        }
    }
}
