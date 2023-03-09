using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission9.Models;

namespace Mission9.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookStoreRepo onemore { get; set; }
        public PurchaseModel (IBookStoreRepo temp)
        {
            onemore = temp;
        }
        public Cart cart { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost(int bookid)
        {
            Book b = onemore.Books.FirstOrDefault(x => x.BookId == bookid);

            cart = new Cart();

            cart.AddItem(b, 1);

            return RedirectToPage();
        }
    }
}
