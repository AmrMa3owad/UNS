using Microsoft.AspNetCore.Identity;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public interface IUserService : IBaseService<User, int>
    {
        public Task<IdentityResult> Create(User entity, string password);
        new Task<IdentityResult> Create(User entity);
        public Task<User> GetByEmail(string email, CancellationToken cancellationToken);
        public Task<User?> GetByUserNameAndPassword(string email, string password, CancellationToken cancellationToken);
        public Task<SignInResult> SignIn(string email, string password, CancellationToken cancellationToken);
        Task<string> GenerateEmailConfirmationToken(
                    User user);
        Task<IdentityResult> ConfirmEmailAsync(User user,
            string token);

        Task<string> GeneratePasswordResetToken(
         User user);

        Task<IdentityResult> ResetPassword(User user,
         string token, string password);

        Task<IdentityResult> AddPassword(
           User user,
         string password);

        Task<IdentityResult> ChangePassword(
         User user,
       string currentPassword,
     string newPassword);

        Task<bool> CheckPassword(
          User user,
        string password);

        Task<bool> CheckHasPassword(
      User user);
        new Task<IdentityResult> Delete(User entity);
        new Task<IdentityResult> Update(User entity);
    }
}
