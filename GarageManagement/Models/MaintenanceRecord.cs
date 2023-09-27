using System.ComponentModel.DataAnnotations;

namespace GarageManagement.Models;

public class MaintenanceRecord
{
    [Key] // Define a primary key
    public int Id { get; set; } // Assuming the primary key is of type int
    
    public DateTime Date { get; set; }
    public decimal Cost { get; set; }
    public string Workdone { get; set; }
    public Vehicle Vehicle { get; set; }
}