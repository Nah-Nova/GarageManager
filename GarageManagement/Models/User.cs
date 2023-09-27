using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GarageManagement.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        // Navigation property to roles
        public List<UserRole>? UserRoles { get; set; }
    }

    public class Role
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        // Navigation property to users
        public List<UserRole>? UserRoles { get; set; }
    }

    public class UserRole
    {
        [Key]
        public int Id { get; set; }

        // Foreign keys
        public int UserId { get; set; }
        public int RoleId { get; set; }

        // Navigation properties
        public User? User { get; set; }
        public Role? Role { get; set; }
    }
}