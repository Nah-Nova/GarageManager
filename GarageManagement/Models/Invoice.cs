using System.ComponentModel.DataAnnotations;

namespace GarageManagement.Models;

public class Invoice
{
    [Key] // Define a primary key
    public int Id { get; set; } // Assuming the primary key is of type int
    
    public string InvoiceNumber { get; set; }
    public DateTime Date { get; set; }
    public Customer? Customer { get; set; }
    public decimal TotalAmount { get; set; }
    public List<Payment>? Payments { get; set; }
}