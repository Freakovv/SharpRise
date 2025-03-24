using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpRise.Models.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterTeacherAsync(string username, string password, string email);
        Task<bool> LoginAsync(string username, string password);
    }
}
