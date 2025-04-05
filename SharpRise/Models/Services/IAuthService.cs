using Microsoft.EntityFrameworkCore;
using SharpRise.Models.Data;
using SharpRise.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpRise.Models.Services
{
    public interface IAuthService
    {
        Task<LoginResult> LoginAsync(string username, string password);
        Task<RegistrationResult> CompleteRegistrationAsync(string token, UserType userType);
        RegistrationResult CreateTemporaryUser(string username, string password, string email);

    }
}
