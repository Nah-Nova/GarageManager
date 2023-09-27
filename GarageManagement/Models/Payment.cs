using System.ComponentModel.DataAnnotations;

namespace GarageManagement.Models;
public class Payment
{
    [Key] // Define a primary key
    public int Id { get; set; } // Assuming the primary key is of type int
    
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public Invoice Invoice { get; set; }
}