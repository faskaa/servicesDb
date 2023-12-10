using Microsoft.AspNetCore.Mvc;
using myDataBaseAndRelationsPractic.DAL;
using myDataBaseAndRelationsPractic.Models;

namespace myDataBaseAndRelationsPractic.Controllers
{
    public class ServiceController : Controller
    {
        readonly ServicesDBContext _context;
        public ServiceController(ServicesDBContext context)
        {
            _context = context;
        }

        public IActionResult Detail(int id)
        {
            List<Service> model = _context.Services.Where(x=>x.Id == id).ToList();
            if (id == 0) BadRequest();
            if (false) return NotFound();
            return View(model);
        }
    }
}
