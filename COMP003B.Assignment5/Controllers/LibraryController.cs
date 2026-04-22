using COMP003B.Assignment5.Data;
using COMP003B.Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment5.Controllers
{
    // Product related IPA request handler
    [ApiController]
    [Route("api/[controller]")]
    public class LibraryController : Controller
    {
        // retrieves full book list in AvailableBooks
        [HttpGet]
        public ActionResult<List<Library>> GetLibrary()
        {
            return Ok(AvailableBooks.Library);
        }
        // checks availableBooks by id 
        [HttpGet("{id}")]

        public ActionResult<Library> GetLibrary(int id)
        {
            var library = AvailableBooks.Library.FirstOrDefault(x => x.Id == id);
            // Should return a 404 message
            if (library == null)
                return NotFound();

            return Ok(library);
        }
        // should allow for the creation of a new product and set new id for said product
        [HttpPost]

        public ActionResult<Library> CreateLibrary(Library library)
        {
            library.Id = AvailableBooks.Library.Max(x => x.Id) + 1;

            AvailableBooks.Library.Add(library);

            return CreatedAtAction(nameof(GetLibrary), new { id = library.Id }, library);
        }
        // should update existing items in the library
        [HttpPut("{id}")]

        public IActionResult UpdateLibrary(int id, Library updateLibrary)
        {
            var existingLibrary = AvailableBooks.Library.FirstOrDefault(x => x.Id == id);

            if (existingLibrary is null)
                return NotFound();

            existingLibrary.Name = updateLibrary.Name;
            existingLibrary.Price = updateLibrary.Price;

            return NoContent();
        }
    }
}
