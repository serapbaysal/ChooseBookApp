using ChooseBookApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChooseBookApp.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke(){
            ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
        
    }
}