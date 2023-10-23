using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskOrganiserWeb.Models
{
    public class Task
    {
   
        [Key]

        public int TaskID { get; set; }

        public string TaskName { get; set; }
        public string Description { get; set; }
        public  string Status { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}
