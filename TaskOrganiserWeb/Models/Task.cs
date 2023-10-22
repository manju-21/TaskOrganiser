using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskOrganiserWeb.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public required string TaskName { get; set; } 
        public string Description { get; set; }
        public required string Status { get; set; }
        public DateTime CreatedDateTime { get; set; }=DateTime.Now;
        //public Task()
        //{
        //    this.Id = 0;
        //    this.TaskId = 0;
        //    this.TaskName = "";
        //    this.Description = "";
        //    this.Status = "";
        //    this.CreatedDateTime = CreatedDateTime;
        //}
    }
}
