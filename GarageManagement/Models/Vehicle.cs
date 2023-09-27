using System.ComponentModel.DataAnnotations;

namespace GarageManagement.Models
{
    public class Vehicle
    {
        [Key] // Define a primary key
        public int Id { get; set; } // Assuming the primary key is of type int

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string ChassisNumber { get; set; }
        public int Mileage { get; set; }
        public string MaintenanceStatus { get; set; }

        [Display(Name = "Owner")]
        public Customer Owner { get; set; }  //To link the vehicle to its owner

        public List<MaintenanceRecord>? MaintenanceRecords { get; set; }
        public List<Invoice>? Invoices { get; set; }
    }
}