using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagement.Models;

public class Invoice
{
    [Key] // Define a primary key
    public int Id { get; set; } // Assuming the primary key is of type int
    
    public string InvoiceNumber { get; set; }
    public DateTime Date { get; set; }
    
    [Display(Name = "Vehicle")]
    public int VehicleId { get; set; } // Store the selected vehicle's ID
    [ForeignKey("VehicleId")] // Define a foreign key
    public Vehicle? Vehicle { get; set; }
    
    public decimal TotalAmount { get; set; }
    public List<Payment>? Payments { get; set; }
}