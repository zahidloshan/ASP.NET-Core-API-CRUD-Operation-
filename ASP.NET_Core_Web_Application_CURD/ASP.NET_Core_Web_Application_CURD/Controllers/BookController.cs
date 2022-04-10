using ASP.NET_Core_Web_Application_CURD.Model;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Web_Application_CURD.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDBContext _db;

        public BookController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult GetAll()
        {
            return Json(new {data=_db.Book.ToList()});
        }
    }
}
