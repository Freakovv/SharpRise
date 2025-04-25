using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpRise.Models.Entities
{
    public class Teacher : User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)] // SharpRise standart
        public required string Username { get; set; }

        [MaxLength(64)] // SHA-256 standart
        public required string Password { get; set; }

        [MaxLength(254)] // RFC 5321 standart
        public required string Email { get; set; }

        // Навигационное свойство для связи "один ко многим" с группами
        public ICollection<Group> Groups { get; set; } = new List<Group>();

        public Teacher Parse(Student student) {
            Id = student.Id;
            Username = student.Username;
            Password = student.Password;
            Email = student.Email;
            Groups = new List<Group>();
            return this;
        }
    }
}
