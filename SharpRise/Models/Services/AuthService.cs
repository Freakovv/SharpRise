using SharpRise.Models.Data;
using SharpRise.Models.Users;
using Microsoft.EntityFrameworkCore;
using SharpRise.Models.Services;
using SharpRise.Security;

namespace SharpRise.Models.Services
{
    public class AuthService : IAuthService
    {
        private readonly SharpRiseContext _context;

        public AuthService(SharpRiseContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterTeacherAsync(string username, string password, string email)
        {
            if (await _context.Teachers.AnyAsync(t => t.Username == username || t.Email == email))
                return false;

            var teacher = new Teacher
            {
                Username = username,
                Password = PasswordHasher.HashPassword(password), 
                Email = email
            };

            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var teacher = await _context.Teachers.FirstOrDefaultAsync(t => t.Username == username);
            if (teacher == null)
                return false;

            return PasswordHasher.VerifyPassword(password, teacher.Password);
        }

    }
}
