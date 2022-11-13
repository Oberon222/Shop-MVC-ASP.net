using Microsoft.AspNetCore.Mvc;
using Shop_MVC2.Data;
using Shop_MVC2.Models;
using System.Collections;
using System.Collections.Generic;

namespace Shop_MVC2.Controllers
{
  public class CategoryController : Controller
  {
    private readonly ApplicationDBContext _db;

    public CategoryController(ApplicationDBContext db)
    {
      _db = db; 
    }

    public IActionResult Index()
    {
      IEnumerable<Category> categoryList = _db.Categories;
      return View(categoryList);
    }
  }
}
