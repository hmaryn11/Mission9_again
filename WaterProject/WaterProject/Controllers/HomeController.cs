using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterProject.Models;
using WaterProject.Models.ViewModels;

namespace WaterProject.Controllers
{
    public class HomeController : Controller
    {

        private IBookStoreRepo repo;

        public HomeController (IBookStoreRepo temp)
        {
            repo = temp;
        }

        public int BooksPerPage { get; private set; }
        public object CurrentPage { get; private set; }

        public IActionResult Index(int pageNum = 1) //if nothing else comes in, pagenum=1
        {
            int pageSize = 5;

            var x = new ProjectsViewModel
            {
                Books = repo.Projects
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Projects.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }
        //The below method does the same as the above method
        //public IActionResult Index() => View();
    }
}
//lamda jumps straight to the result of the method