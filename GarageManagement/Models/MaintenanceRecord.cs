using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagement.Models;

public class MaintenanceRecord
{
    [Key] // Define a primary key
    public int Id { get; set; } // Assuming the primary key is of type int
    
    public DateTime Date { get; set; }
    public decimal Cost { get; set; }
    public string Workdone { get; set; }
    
    [Display(Name = "Vehicle")]
    public int VehicleId { get; set; } // Store the selected vehicle's ID
    [ForeignKey("VehicleId")] // Define a foreign key

    public Vehicle? Vehicle { get; set; }
}