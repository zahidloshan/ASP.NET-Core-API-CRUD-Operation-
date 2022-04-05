using ASP.NET_Core_Web_Application_CURD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Web_Application_CURD.Pages.BookPage
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public IEnumerable<Book> Books { get; set; }

        public async void OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }
    }
}
