﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrsWebNet.Models;

namespace PrsWebNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineItemsController : ControllerBase
    {
        private readonly PrsDbContext _context;

        public LineItemsController(PrsDbContext context)
        {
            _context = context;
        }

        // GET: api/LineItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LineItem>>> GetLineItem()
        {
            return await _context.LineItem.Include(li => li.Product)
                                          .Include(li => li.Request)
                                          .ToListAsync();
        }

        // GET: api/LineItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LineItem>> GetLineItem(int id)
        {
            var lineItem = await _context.LineItem.Include(li => li.Product)
                                          .Include(li => li.Request)
                                          .FirstOrDefaultAsync(li => li.Id == id);

            if (lineItem == null)
            {
                return NotFound();
            }

            return lineItem;
        }

        // PUT: api/LineItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLineItem(int id, LineItem lineItem)
        {
            if (id != lineItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(lineItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineItemExists(id))
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

        // POST: api/LineItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LineItem>> PostLineItem(LineItem lineItem)
        {
            _context.LineItem.Add(lineItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLineItem", new { id = lineItem.Id }, lineItem);
        }

        // DELETE: api/LineItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLineItem(int id)
        {
            var lineItem = await _context.LineItem.FindAsync(id);
            if (lineItem == null)
            {
                return NotFound();
            }

            _context.LineItem.Remove(lineItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LineItemExists(int id)
        {
            return _context.LineItem.Any(e => e.Id == id);
        }
    }
}
