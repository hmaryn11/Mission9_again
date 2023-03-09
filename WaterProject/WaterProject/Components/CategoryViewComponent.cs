using Microsoft.AspNetCore.Mvc;
using Mission9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private IBookStoreRepo another { get; set; }

        public CategoryViewComponent (IBookStoreRepo temp)
        {
            another = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["bookCat"];

            var categories = another.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(categories);
        }
    }
}
