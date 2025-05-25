using SharpRise.src.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpRise.src.Models.Services
{
    public static class UserMapper
    {
        public static Student ToStudent(this User user)
        {
            return new Student
            {
                Username = user.Username,
                Password = user.Password,
                Email = user.Email,
                Groups = new List<Group>()
            };
        }

        public static Teacher ToTeacher(this User user)
        {
            return new Teacher
            {
                Username = user.Username,
                Password = user.Password,
                Email = user.Email,
                Groups = new List<Group>()
            };
        }
    }
}
