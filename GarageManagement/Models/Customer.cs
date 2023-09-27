using System.ComponentModel.DataAnnotations;

namespace GarageManagement.Models;
public class Customer
{
    [Key] // Define a primary key
    public int Id { get; set; } // Assuming the primary key is of type int

    public string Name { get; set; }
    public string ContactInformation { get; set; }
    // Other properties

    // Navigation property to related entities
    public List<Vehicle> Vehicles { get; set; }
}
