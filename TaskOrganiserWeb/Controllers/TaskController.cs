using Microsoft.AspNetCore.Mvc;
using TaskOrganiserWeb.Data;

namespace TaskOrganiserWeb.Controllers
{
    public class TaskController : Controller
    {

        private readonly ApplicationDbContext _db;
        public TaskController(ApplicationDbContext db)
        {
                _db = db;
        }
        public IActionResult Index()
        {
            var objTaskList=_db.Tasks.ToList();
            return View();
        }
    }
}
