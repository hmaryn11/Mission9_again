using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission9.Infrastructure;
using Mission9.Models;

namespace Mission9.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookStoreRepo onemore { get; set; }
        public Cart cart { get; set; }
        public string ReturnUrl { get; set; }

        public PurchaseModel (IBookStoreRepo temp, Cart c)
        {
            onemore = temp;
            cart = c;
        }


        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int bookid, string returnUrl)
        {
            Book b = onemore.Books.FirstOrDefault(x => x.BookId == bookid);

            cart.AddItem(b, 1);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookid, string returnUrl)
        {
            cart.RemoveItem(cart.Items.First(x => x.Book.BookId == bookid).Book);
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
