using System.ComponentModel.DataAnnotations;

namespace GarageManagement.Models;
public class InventoryItem
{
    [Key] // Define a primary key
    public int Id { get; set; } // Assuming the primary key is of type int
    
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}