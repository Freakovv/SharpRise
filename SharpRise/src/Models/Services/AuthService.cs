using SharpRise.src.Models.Entities;
using Microsoft.EntityFrameworkCore;
using SharpRise.src.Models.Data;
using SharpRise.src.Models.Security;

namespace SharpRise.src.Models.Services
{
    public enum UserType
    {
        Teacher,
        Student
    }    
    public enum ErrorType
    {
        ExistsEmail,
        ExistsUsername,
        InvalidPassword,
        Unkown
    }
    public class RegistrationResult
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
        public User? User { get; set; }
        public ErrorType? ErrorType { get; set; }
    }
    public class LoginResult
    {
        public bool Success { get; set; }
        public UserType UserType { get; set; }
        public User? User { get; set; }
        public string? Error { get; set; }
        public ErrorType? ErrorType { get; set; }
    }
    public class AuthService : IAuthService
    {
        private readonly SharpRiseContext _context;
        private Dictionary<string, User> _temporaryUsers = new();

        public AuthService(SharpRiseContext context)
        {
            _context = context;
        }

        // Создание временного пользователя
        public RegistrationResult CreateTemporaryUser(string username, string password, string email)
        {
            // Проверка уникальности
            if (_context.Teachers.Any(t => t.Username == username) ||
                _context.Students.Any(s => s.Username == username))
            {
                return new RegistrationResult
                {
                    Success = false,
                    ErrorMessage = "Это имя пользователя уже занято",
                    ErrorType = ErrorType.ExistsUsername
                };
            }

            if (_context.Teachers.Any(t => t.Email == email) ||
                _context.Students.Any(s => s.Email == email))
            {
                return new RegistrationResult
                {
                    Success = false,
                    ErrorMessage = "Данный Email уже зарегистрирован",
                    ErrorType = ErrorType.ExistsEmail
                };
            }

            var tempUser = new User
            {
                Username = username,
                Password = Hasher.HashPassword(password),
                Email = email
            };

            // Сохраняем временного пользователя в памяти
            var token = Guid.NewGuid().ToString();
            _temporaryUsers[token] = tempUser;

            return new RegistrationResult
            {
                Success = true,
                User = tempUser,
                // Возвращаем токен для последующего подтверждения
                ErrorMessage = token
            };
        }

        // Подтверждение роли и сохранение
        public async Task<RegistrationResult> CompleteRegistrationAsync(string token, UserType userType)
        {
            if (!_temporaryUsers.TryGetValue(token, out var tempUser))
            {
                return new RegistrationResult
                {
                    Success = false,
                    ErrorMessage = "Недействительный токен регистрации",
                    ErrorType = ErrorType.Unkown
                };
            }

            try
            {
                User newUser;

                if (userType == UserType.Teacher)
                {
                    var teacher = new Teacher
                    {
                        Username = tempUser.Username,
                        Password = tempUser.Password,
                        Email = tempUser.Email
                    };
                    _context.Teachers.Add(teacher);
                    newUser = teacher;
                }
                else
                {
                    var student = new Student
                    {
                        Username = tempUser.Username,
                        Password = tempUser.Password,
                        Email = tempUser.Email
                    };
                    _context.Students.Add(student);
                    newUser = student;
                }

                await _context.SaveChangesAsync();
                _temporaryUsers.Remove(token); 

                return new RegistrationResult
                {
                    Success = true,
                    User = newUser
                };
            }
            catch (Exception ex)
            {
                return new RegistrationResult
                {
                    Success = false,
                    ErrorMessage = $"Ошибка регистрации: {ex.Message}",
                    ErrorType = ErrorType.Unkown
                };
            }
        }

        // Авторизация
        public async Task<LoginResult> LoginAsync(string username, string password) {
            //for teachers
            var teacher = await _context.Teachers
                .FirstOrDefaultAsync(t => t.Username == username);

            if (teacher != null)
            {
                if (!Hasher.VerifyPassword(password, teacher.Password))
                    return new LoginResult { Error = "Неверное имя пользователя или пароль" };

                return new LoginResult
                {
                    Success = true,
                    User = teacher,
                    UserType = UserType.Teacher
                };
            }

            //for students
            var student = await _context.Students
                .FirstOrDefaultAsync(s => s.Username == username);

            if (student != null)
            {
                if (!Hasher.VerifyPassword(password, student.Password))
                    return new LoginResult { Error = "Неверное имя пользователя или пароль" };

                return new LoginResult
                {
                    Success = true,
                    User = student,
                    UserType = UserType.Student
                };
            }

            return new LoginResult { Error = "Пользователь не найден" };
        }
    }
}
