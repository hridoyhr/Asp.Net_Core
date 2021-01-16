using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor2.Pages.BookList
{
    public class Index1Model : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Index1Model(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]

        public Book Book { get; set;}

        public void OnGet()
        {

        }

        //post Handeler

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Book.AddAsync(Book);
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
