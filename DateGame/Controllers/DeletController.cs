using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DateGame.Models;

namespace DateGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeletController : ControllerBase
    {
        private readonly DbContent _context;

        public DeletController(DbContent context)
        {
            _context = context;
        }

        // GET: api/Delet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> Getgames()
        {
            return await _context.games.ToListAsync();
        }

        // GET: api/Delet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGame(int id)
        {
            var game = await _context.games.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }

        // PUT: api/Delet/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(int id, Game game)
        {
            if (id != game.id)
            {
                return BadRequest();
            }

            _context.Entry(game).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(id))
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

        // POST: api/Delet
        [HttpPost]
        public async Task<ActionResult<Game>> PostGame(Game game)
        {
            _context.games.Add(game);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGame", new { id = game.id }, game);
        }

        // DELETE: api/Delet/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Game>> DeleteGame(int id)
        {
            var game = await _context.games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            _context.games.Remove(game);
            await _context.SaveChangesAsync();

            return game;
        }

        private bool GameExists(int id)
        {
            return _context.games.Any(e => e.id == id);
        }
    }
}
