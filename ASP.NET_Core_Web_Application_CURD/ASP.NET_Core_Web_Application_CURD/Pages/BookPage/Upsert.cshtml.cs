using ASP.NET_Core_Web_Application_CURD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Web_Application_CURD.Pages.BookPage
{
    public class UpsertModel : PageModel
    {
        private ApplicationDBContext _db;

        public UpsertModel(ApplicationDBContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task<IActionResult> OnGet(int? id)//Nullable ID
        {
            Book = new Book();
            //Create Book using same page
            if(id==null)
            {
                return Page();
            }
            //Update Book using same page
            Book = await _db.Book.FirstOrDefaultAsync(u => u.Id == id);
            if(Book==null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                /* var BookFromDb = await _db.Book.FindAsync(Book.Id);
                BookFromDb.Name = Book.Name;
                BookFromDb.Author = Book.Author;
                BookFromDb.Token = Book.Token;*/
                if(Book.Id==0)
                {
                    _db.Book.Add(Book);
                }
                else
                {
                    _db.Book.Update(Book);
                }
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
