namespace PlanningPoker.Models;
using System.ComponentModel.DataAnnotations;

public class Room
{
    [Key]
    public int RoomID { get; set; }
    public string Name { get; set; }
}
