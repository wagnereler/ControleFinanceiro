using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeEnumsController : ControllerBase
    {
        private readonly Context _context;

        public TypeEnumsController(Context context)
        {
            _context = context;
        }

        // GET: api/TypeEnums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeEnum>>> GetTypeEnums()
        {
            return await _context.TypeEnums.ToListAsync();
        }

        // GET: api/TypeEnums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeEnum>> GetTypeEnum(int id)
        {
            var typeEnum = await _context.TypeEnums.FindAsync(id);

            if (typeEnum == null)
            {
                return NotFound();
            }

            return typeEnum;
        }

        // PUT: api/TypeEnums/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeEnum(int id, TypeEnum typeEnum)
        {
            if (id != typeEnum.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(typeEnum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeEnumExists(id))
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

        // POST: api/TypeEnums
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TypeEnum>> PostTypeEnum(TypeEnum typeEnum)
        {
            _context.TypeEnums.Add(typeEnum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeEnum", new { id = typeEnum.TypeId }, typeEnum);
        }

        // DELETE: api/TypeEnums/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TypeEnum>> DeleteTypeEnum(int id)
        {
            var typeEnum = await _context.TypeEnums.FindAsync(id);
            if (typeEnum == null)
            {
                return NotFound();
            }

            _context.TypeEnums.Remove(typeEnum);
            await _context.SaveChangesAsync();

            return typeEnum;
        }

        private bool TypeEnumExists(int id)
        {
            return _context.TypeEnums.Any(e => e.TypeId == id);
        }
    }
}
