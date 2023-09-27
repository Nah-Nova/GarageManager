using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagement.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        public string RegistrationNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string ChassisNumber { get; set; }
        public int Mileage { get; set; }
        public string MaintenanceStatus { get; set; }

        [Display(Name = "Owner")]
        public int OwnerId { get; set; } // Store the selected customer's ID

        [ForeignKey("OwnerId")]
        public Customer? Owner { get; set; }

        public List<MaintenanceRecord>? MaintenanceRecords { get; set; }
        public List<Invoice>? Invoices { get; set; }
    }

}