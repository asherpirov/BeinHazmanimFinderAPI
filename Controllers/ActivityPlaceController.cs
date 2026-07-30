using BeinHazmanimFinderAPI.Models;
using BeinHazmanimFinderAPI.Ripositories;
using Microsoft.AspNetCore.Mvc;

namespace BeinHazmanimFinderAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivityPlaceController : ControllerBase
    {
        private readonly IActivityPlacesRepository _ripository;

        public ActivityPlaceController(IActivityPlacesRepository repository)
        {
            _ripository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityPlace>>> GetAllAsync()
        {
            var activityPlaces = await _ripository.GetAllAsync();
            return Ok(activityPlaces);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityPlace>> GetByIdAsync(int id)
        {
            var activityPlace = await _ripository.GetByIdAsync(id);

            if (activityPlace == null)
            {
                return NotFound();
            }
            return Ok(activityPlace);
        }

        [HttpPost]
        public async Task<ActionResult<ActivityPlace>> CreateAsync(ActivityPlace activityPlace)
        {
            var created = await _ripository.CreateAsync(activityPlace);

            return CreatedAtAction("GetById", new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, ActivityPlace activityPlace)
        {
            var existing = await _ripository.UpdateAsync(id, activityPlace);

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
        public async Task<ActionResult<IEnumerable<ActivityPlace>>> SearchAsync(
            [FromQuery] string? category, [FromQuery] string? city, [FromQuery] decimal? maxPrice, [FromQuery] string? audience)
        {
            var query = await _ripository.SearchAsync(category, city, maxPrice, audience);

            return Ok(query);
        }

    };
}
