using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows;
using System.Linq;

namespace SharpRise.Models.Users
{
    public class Group
    {
        [Key] 
        public int Id { get; set; }

        [MaxLength(50)] // SharpRise стандарт
        public required string Name { get; set; }

        [MaxLength(200)] // SharpRise стандарт
        public required string Description { get; set; }

        [MaxLength(30)] // SharpRise стандарт
        public required string TeacherUsername { get; set; }

        public required bool IsVerificated { get; set; }

        public required DateTime CreationDate { get; set; }

        [MaxLength(9)] 
        public string? InviteCode { get; set; }

        // Навигационное свойство для связи "многие ко многим"
        public ICollection<Student> Students { get; set; } = new List<Student>();

        public int TeacherId { get; set; } // Внешний ключ
        public Teacher Teacher { get; set; } // Навигационное свойство
        //internal static string GenerateInviteCode()
        //{
        //    Random _random = new Random();
        //    string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    string Numbers = "0123456789";

        //    var letterPart = new string(Enumerable.Repeat(Letters, 4)
        //       .Select(s => s[_random.Next(s.Length)])
        //       .ToArray());

        //    var numberPart = new string(Enumerable.Repeat(Numbers, 4)
        //        .Select(s => s[_random.Next(s.Length)])
        //        .ToArray());

        //    return $"{letterPart}-{numberPart}";
        //}
    }
}