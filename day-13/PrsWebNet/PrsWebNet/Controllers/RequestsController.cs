using System;
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
    public class RequestsController : ControllerBase
    {
        const string STATUS_NEW = "NEW";
        const string STATUS_REVIEW = "REVIEW";
        const string STATUS_APPROVED = "APPROVED";
        const string STATUS_REJECTED = "REJECTED";

        private readonly PrsDbContext _context;

        public RequestsController(PrsDbContext context)
        {
            _context = context;
        }

        // GET: api/Requests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Request>>> GetRequests()
        {
            var requests = _context.Requests.Include(r => r.User);
            return await requests.ToListAsync();
        }

        // GET: api/Requests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Request>> GetRequest(int id)
        {
            var request = await _context.Requests.Include(r => r.User).FirstOrDefaultAsync(r => r.Id == id);

            if (request == null)
            {
                return NotFound();
            }

            return request;
        }

        // PUT: api/Requests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequest(int id, Request request)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }

            _context.Entry(request).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestExists(id))
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

        // POST: api/Requests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Request>> PostRequest(Request request)
        {
            request.Status = STATUS_NEW;
            request.SubmittedDate = DateTime.Now;
            _context.Requests.Add(request);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRequest", new { id = request.Id }, request);
        }

        // DELETE: api/Requests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequest(int id)
        {
            var request = await _context.Requests.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }

            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/requests/review/5
        [HttpPost("review/{id}")]
        public async Task<ActionResult<Request>> SubmitRequestReview(int id) {

            var request = await _context.Requests.FirstOrDefaultAsync(r => r.Id == id);

            if (request == null) {
                return NotFound();
            }
            else if (request.Status != STATUS_NEW) {
                return Problem($"Request status must be {STATUS_NEW} before it can be submitted for {STATUS_REVIEW}.");
            }

            if (request.Total <= 50)
                request.Status = STATUS_APPROVED;
            else
                request.Status = STATUS_REVIEW;

            // update SubmittedDate to reflect current time
            request.SubmittedDate = DateTime.Now;

            try {
                await _context.SaveChangesAsync();
            }
            catch (Exception) {
                //return StatusCode(500);
                return Problem("Error subbmiting request for review.");
            }

            return request;
        }


        // POST: api/requests/reject/5
        [HttpPost("reject/{id}")]
        public async Task<ActionResult<Request>> RejectRequest(int id, [FromBody] string rejectReason) {
            if (rejectReason == null) {
                return BadRequest("Reason for Rejection field is required.");
            }

            var request = await _context.Requests.FirstOrDefaultAsync(r => r.Id == id);

            if (request == null) {
                return NotFound();
            }
            else if (request.Status != STATUS_REVIEW) {
                return Problem($"Request status must be {STATUS_REVIEW} before it can be {STATUS_REJECTED}.");
            }

            request.ReasonForRejection = rejectReason;
            request.Status = STATUS_REJECTED;

            try {
                await _context.SaveChangesAsync();
            }
            catch (Exception) {
                //return StatusCode(500);
                return Problem("Error rejecting request.");
            }

            return request;
        }

        // POST: api/requests/approve/5
        [HttpPost("approve/{id}")]
        public async Task<ActionResult<Request>> ApproveRequest(int id) {

            var request = await _context.Requests.FirstOrDefaultAsync(r => r.Id == id);

            if (request == null) {
                return NotFound();
            }
            else if (request.Status != STATUS_REVIEW) {
                return Problem($"Request status must be {STATUS_REVIEW} before it can be {STATUS_APPROVED}.");
            }

            request.Status = STATUS_APPROVED;

            try {
                await _context.SaveChangesAsync();
            }
            catch (Exception) {
                return Problem("Error approving request.");
            }

            return request;
        }

        // GET: api/Requests
        [HttpGet("reviews/{id}")]
        public async Task<ActionResult<IEnumerable<Request>>> GetRequestsForReview(int id) {
            var requests = await _context.Requests.Include(r => r.User)
                .Where(r => r.UserId != id && r.Status == STATUS_REVIEW).ToListAsync();
            return requests;
        }

        private bool RequestExists(int id)
        {
            return _context.Requests.Any(e => e.Id == id);
        }
    }
}
