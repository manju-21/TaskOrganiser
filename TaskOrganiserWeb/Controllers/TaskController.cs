using Microsoft.AspNetCore.Mvc;
using TaskOrganiserWeb.Data;
using Task = TaskOrganiserWeb.Models.Task;

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
            IEnumerable<Task>objTaskList=_db.Tasks.ToList();
            return View(objTaskList);
        }
    }
}
