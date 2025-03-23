using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpRise.Models.Users
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)] // SharpRise стандарт
        public required string Username { get; set; }

        [MaxLength(64)] // SHA-256 стандарт
        public required string Password { get; set; }

        [MaxLength(254)] // RFC 5321 стандарт
        public required string Email { get; set; }

        // Навигационное свойство для связи "один ко многим" с группами
        public ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
