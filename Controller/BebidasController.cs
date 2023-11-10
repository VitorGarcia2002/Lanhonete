using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BebidasController : ControllerBase
    {
        private readonly DataContext _context;

        public BebidasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Bebidas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bebidas>>> GetBebidas()
        {
          if (_context.Bebidas == null)
          {
              return NotFound();
          }
            return await _context.Bebidas.ToListAsync();
        }

        // GET: api/Bebidas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bebidas>> GetBebidas(int id)
        {
          if (_context.Bebidas == null)
          {
              return NotFound();
          }
            var bebidas = await _context.Bebidas.FindAsync(id);

            if (bebidas == null)
            {
                return NotFound();
            }

            return bebidas;
        }

        // PUT: api/Bebidas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBebidas(int id, Bebidas bebidas)
        {
            if (id != bebidas.Id)
            {
                return BadRequest();
            }

            _context.Entry(bebidas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BebidasExists(id))
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

        // POST: api/Bebidas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bebidas>> PostBebidas(Bebidas bebidas)
        {
          if (_context.Bebidas == null)
          {
              return Problem("Entity set 'DataContext.Bebidas'  is null.");
          }
            _context.Bebidas.Add(bebidas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBebidas", new { id = bebidas.Id }, bebidas);
        }

        // DELETE: api/Bebidas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBebidas(int id)
        {
            if (_context.Bebidas == null)
            {
                return NotFound();
            }
            var bebidas = await _context.Bebidas.FindAsync(id);
            if (bebidas == null)
            {
                return NotFound();
            }

            _context.Bebidas.Remove(bebidas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BebidasExists(int id)
        {
            return (_context.Bebidas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
