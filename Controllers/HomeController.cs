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

        public IActionResult Index()
        {
            BookCategoryModel model = new BookCategoryModel();
            model.Categories = CategoryRepository.Categories;
            model.Books = BookRepository.Books;
            return View(model);
        }
        
        public IActionResult Details(int id)
        {
            BookCategoryModel model = new BookCategoryModel();
            model.Categories = CategoryRepository.Categories;
            model.Book = BookRepository.GetById(id);
          
          return View(model);
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
