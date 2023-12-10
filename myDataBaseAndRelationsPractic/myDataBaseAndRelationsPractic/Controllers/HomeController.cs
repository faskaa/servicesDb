using Microsoft.AspNetCore.Mvc;
using myDataBaseAndRelationsPractic.DAL;
using myDataBaseAndRelationsPractic.Models;

namespace myDataBaseAndRelationsPractic.Controllers
{
    public class HomeController : Controller
    {   
        readonly ServicesDBContext _context;
        public HomeController(ServicesDBContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            
            List<Service> model = _context.Services.ToList();
            return View(model);
        }

    }
}
