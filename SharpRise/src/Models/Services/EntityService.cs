using Microsoft.EntityFrameworkCore;
using SharpRise.src.Models.Entities;
using SharpRise.src.Models.Data;

namespace SharpRise.src.Models.Services
{
    public class EntityService : IDisposable
    {
        private readonly SharpRiseContext _context;
        private bool _disposed = false;
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

        public async Task<Group?> GetGroupByInviteCodeAsync(string inviteCode)
        {
            return await _context.Groups
                .FirstOrDefaultAsync(g => g.InviteCode == inviteCode);
        }

        public async Task AddStudentToGroupAsync(int studentId, int groupId)
        {
            var group = await _context.Groups
                .Include(g => g.Students)
                .FirstOrDefaultAsync(g => g.Id == groupId);

            var student = await _context.Students.FindAsync(studentId);

            if (group == null || student == null)
                throw new ArgumentException("Group or Student not found");

            if (!group.Students.Any(s => s.Id == studentId))
            {
                group.Students.Add(student);
                await _context.SaveChangesAsync();
            }
        }
        // Для создания контекста
        static internal EntityService CreateEntityService()
        {
            var context = new ShariRiseContextFactory().CreateDbContext(null);
            return new EntityService(context);
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

        #region IDisposable Implementation
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}