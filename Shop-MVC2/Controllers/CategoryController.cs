using Microsoft.AspNetCore.Mvc;

namespace Shop_MVC2.Controllers
{
  public class CategoryController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
