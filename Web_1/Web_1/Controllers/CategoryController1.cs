using Microsoft.AspNetCore.Mvc;
using Web_1.DataB;
using Web_1.Models;

namespace Web_1.Controllers
{
    public class CategoryController : Controller
    {
       // private readonly DataDbContext  _db;

       // public CategoryController(DataDbContext db)
       // {
       //     _db = db;
        //}

        public IActionResult Index()
        {
           // IEnumerable<Category> objList = _db.Category;
            return View();
        }
    }
}
