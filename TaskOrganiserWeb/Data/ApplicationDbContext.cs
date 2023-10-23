using Microsoft.EntityFrameworkCore;
using TaskOrganiserWeb.Models;
using Task = TaskOrganiserWeb.Models.Task;

namespace TaskOrganiserWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
                
        }

        public DbSet<Task> Tasks { get; set; }

    }
}
