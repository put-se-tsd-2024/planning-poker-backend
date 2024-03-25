using System.ComponentModel.DataAnnotations;

namespace PlanningPoker.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public Room Room { get; set; }
        public string Username { get; set; }
    }
}
