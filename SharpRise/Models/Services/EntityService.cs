using Microsoft.EntityFrameworkCore;
using SharpRise.Models.Data;
using SharpRise.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpRise.Services
{
    public class EntityService
    {
        private readonly SharpRiseContext _context;

        public EntityService(SharpRiseContext context)
        {
            _context = context;
        }

        #region CRUD Operations
        // Добавление 
        public async Task AddEntityAsync<T>(T entity) where T : class
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        // Обновление 
        public async Task UpdateEntityAsync<T>(T entity) where T : class
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        // Удаление 
        public async Task DeleteEntityAsync<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        // Получение по ID
        //public async Task<T?> GetByIdAsync<T>(int id) where T : class
        //{
        //    return await _context.Set<T>().FindAsync(id);
        //}
        #endregion

        #region Specialized Methods
        // Для Group
        public async Task<Group> CreateGroupAsync(string name, string teacherUsername, int teacherId)
        {
            var group = new Group
            {
                Name = name,
                Description = string.Empty,
                IsVerificated = false,
                CreationDate = DateTime.Now,
                InviteCode = Group.GenerateInviteCode(),
                TeacherUsername = teacherUsername,
                TeacherId = teacherId
            };

            await AddEntityAsync(group);
            return group;
        }

        // Для Student
        public async Task<Student> CreateStudentAsync(string username, string password, string email)
        {
            var student = new Student
            {
                Username = username,
                Password = password,
                Email = email
            };

            await AddEntityAsync(student);
            return student;
        }

        // Для Teacher
        public async Task<Teacher> CreateTeacherAsync(string username, string password, string email)
        {
            var teacher = new Teacher
            {
                Username = username,
                Password = password,
                Email = email
            };

            await AddEntityAsync(teacher);
            return teacher;
        }

        // Добавление студента в группу
        public async Task AddStudentToGroupAsync(int studentId, int groupId)
        {
            var student = await _context.Students
                .Include(s => s.Groups)
                .FirstOrDefaultAsync(s => s.Id == studentId);

            var group = await _context.Groups.FindAsync(groupId);

            if (student != null && group != null)
            {
                student.Groups.Add(group);
                await _context.SaveChangesAsync();
            }
        }

        #endregion

        #region Exists Methods

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _context.Students.AnyAsync(s => s.Email == email) ||
                   await _context.Teachers.AnyAsync(t => t.Email == email);
        }        
        public async Task<bool> UsernameExistsAsync(string username)
        {
            return await _context.Students.AnyAsync(s => s.Username == username) ||
                   await _context.Teachers.AnyAsync(t => t.Username == username);
        }

        #endregion

        #region Query Methods
        //public IQueryable<T> Query<T>() where T : class
        //{
        //    return _context.Set<T>().AsQueryable();
        //}

        //public async Task<List<T>> GetAllAsync<T>() where T : class
        //{
        //    return await _context.Set<T>().ToListAsync();
        //}
        #endregion
    }
}