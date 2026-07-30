using BeinHazmanimFinderAPI.Models;
using BeinHazmanimFinderAPI.Ripositories;
using Microsoft.AspNetCore.Mvc;

namespace BeinHazmanimFinderAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AccommodationController : ControllerBase
    {
        private readonly IAccommodationsRipository _ripository;

        public AccommodationController(IAccommodationsRipository repository)
        {
            _ripository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Accommodation>>> GetAllAsync()
        {
            var accommodations = await _ripository.GetAllAsync();
            return  Ok(accommodations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Accommodation>> GetByIdAsync(int id)
        {
            var accommodation = await _ripository.GetByIdAsync(id);

            if (accommodation == null)
            {
                return NotFound();
            }
            return Ok(accommodation);
        }

        [HttpPost]
        public async Task<ActionResult<Accommodation>> CreateAsync(Accommodation accommodation)
        {
            var created = await _ripository.CreateAsync(accommodation);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, Accommodation accommodation)
        {
            var existing = await _ripository.UpdateAsync(id, accommodation);

            if (existing == null)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var success = await _ripository.DeleteAsync(id);

            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Accommodation>>> SreachAsync(
            [FromQuery] string? city, [FromQuery] decimal? maxPrice, [FromQuery] bool? accessible)
        {

            var query = await _ripository.SreachAsync(city, maxPrice, accessible);

            return Ok(query);

        }

    };
}

