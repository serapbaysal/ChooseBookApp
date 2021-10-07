using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChooseBookApp.Models;
using ChooseBookApp.Data;



namespace ChooseBookApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id)
        {
            var books = BookRepository.Books;
            if(id != null) {
                books = books.Where( i => i.CategoryId == id).ToList();
            }

            return View(books);
        }
        
        public IActionResult Details(int id)
        {
           
          
          return View(BookRepository.GetById(id));
        }

        [Route("/privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("/contact")]
        public IActionResult Contact()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
