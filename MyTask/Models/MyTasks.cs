using System.ComponentModel.DataAnnotations;

namespace MyTask.Models
{
    public class MyTasks
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
    }
}
