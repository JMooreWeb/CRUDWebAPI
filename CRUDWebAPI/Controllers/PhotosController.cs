using CRUDWebAPI.Data;
using CRUDWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ILogger<PhotosController> _logger;

        public PhotosController(DataContext context, ILogger<PhotosController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/Photos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Photo>>> Get()
        {
            var photos = await _context.Photos.ToListAsync();
            return Ok(photos);
        }

        // GET: api/Photos/1
        [HttpGet("{id}", Name="Get")]
        public async Task<ActionResult<Photo>> Get(int id)
        {
            var photo = await _context.Photos.FindAsync(id);
            return Ok(photo);
        }

        // POST: api/Photos
        [HttpPost]
        public void Post([FromBody] string photo)
        {
        }

        // PUT: api/Photos/1
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string photo)
        {
        }

        // DELETE: api/Photos/1
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
