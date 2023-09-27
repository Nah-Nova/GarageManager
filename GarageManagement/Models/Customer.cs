using System.ComponentModel.DataAnnotations;

namespace GarageManagement.Models;
public class Customer
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    public string ContactInformation { get; set; }

    // Navigation property to related vehicles
    public List<Vehicle>? Vehicles { get; set; }
}

