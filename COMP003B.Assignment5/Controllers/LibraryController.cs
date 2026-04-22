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
        // retrieves product
        [HttpGet]
        public ActionResult<List<Library>> GetLibrary()
        {
            return Ok(AvailableBooks.Library);
        }
    }
}
