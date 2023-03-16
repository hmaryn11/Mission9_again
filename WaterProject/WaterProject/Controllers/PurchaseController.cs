using Microsoft.AspNetCore.Mvc;
using Mission9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Controllers
{
    public class PurchaseController : Controller
    {
        private IPurchaseRepo repo { get; set; }
        private Cart cart { get; set; }

        public PurchaseController(IPurchaseRepo temp, Cart c)
        {
            repo = temp;
            cart = c;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new ActualPurchases());
        }

        [HttpPost]
        public IActionResult Checkout(ActualPurchases purchase)
        {
            if(cart.Items.Count() ==0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty.");
            }

            if(ModelState.IsValid)
            {
                purchase.Lines = cart.Items.ToArray();
                repo.SavePurchase(purchase);
                cart.ClearCart();

                return RedirectToPage("/PurchaseComplete");
            }
            else
            {
                return View();
            }
        }
    }
}
