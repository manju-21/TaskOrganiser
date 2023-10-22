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
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string TaskName { get; set; }
        public string Description { get; set; }
        public required string Status { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
