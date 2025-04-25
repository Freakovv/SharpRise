namespace SharpRise.src.Models.Services
{
    public interface IAuthService
    {
        Task<LoginResult> LoginAsync(string username, string password);
        Task<RegistrationResult> CompleteRegistrationAsync(string token, UserType userType);
        RegistrationResult CreateTemporaryUser(string username, string password, string email);

    }
}
