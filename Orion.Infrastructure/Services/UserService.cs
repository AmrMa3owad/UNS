using Microsoft.EntityFrameworkCore;
using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace Orion.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> UserManager;

        private readonly AppDbContext Context;
        public UserService(
            UserManager<User> userManager,
            AppDbContext dbContext
            )
        {
            UserManager = userManager;
            Context = dbContext;
        }

        public async Task<IdentityResult> Create(User entity)
        {
            IdentityResult identityResult = await UserManager.CreateAsync(entity);

            return identityResult;

        }

        public async Task<IdentityResult> Create(User entity, string password)
        {
            IdentityResult identityResult = await UserManager.CreateAsync(entity, password);

            return identityResult;
        }

        public async Task<IdentityResult> Delete(User entity)
        {
            IdentityResult identityResult = await UserManager.DeleteAsync(entity);
            return identityResult;
        }

        public Task<User?> Get(int id, CancellationToken cancellationToken)
        {
            return UserManager.Users
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();
        }

        public IQueryable<User> GetAll(CancellationToken cancellationToken)
        {
            return UserManager.Users.AsQueryable();
        }

        public async Task<User?> GetByEmail(string email, CancellationToken cancellationToken)
        {
            User userCheck = await UserManager
                .FindByEmailAsync(email);
            return userCheck;
        }
        public async Task<SignInResult> SignIn(string email, string password, CancellationToken cancellationToken)
        {
            User user = await GetByEmail(email, cancellationToken);
            bool lockedOut = await UserManager.IsLockedOutAsync(user);
            //bool emailConfirmed = await UserManager.IsEmailConfirmedAsync(user);

            //if (!emailConfirmed)
            //{
            //    return SignInResult.NotAllowed;
            //    // return Email Not comfirmed
            //}
            if (lockedOut)
            {
                return SignInResult.LockedOut;

                // return lockedOut
            }
            else
            {
                bool correctPassword
                               = await UserManager.CheckPasswordAsync(user, password);

                return correctPassword ? SignInResult.Success : SignInResult.Failed;
            }
        }

        public async Task<User?> GetByUserNameAndPassword(string email, string password, CancellationToken cancellationToken)
        {

            var userCheck = await UserManager.FindByEmailAsync(email);
            if (userCheck != null)
            {
                PasswordVerificationResult passwordCheck
                    = UserManager
                    .PasswordHasher
                    .VerifyHashedPassword(userCheck, userCheck.Password, password);

                if (passwordCheck == PasswordVerificationResult.Success)
                {
                    return userCheck;
                }
            }

            return null;
        }

        public async Task<IdentityResult> Update(User entity)
        {
            Context.Users.Update(entity);
            Context.SaveChanges();

            IdentityResult result = await UserManager.UpdateAsync(entity);
            return result;
        }
        public Task<string> GenerateEmailConfirmationToken(
            User user)
        {
            return UserManager.GenerateEmailConfirmationTokenAsync(user);
        }

        public Task<IdentityResult> ConfirmEmailAsync(User user,
          string token)
        {
            return UserManager.ConfirmEmailAsync(user, token);
        }

        public Task<string> GeneratePasswordResetToken(
            User user)
        {
            return UserManager.GeneratePasswordResetTokenAsync(user);
        }

        public Task<IdentityResult> ResetPassword(User user,
          string token, string password)
        {
            return UserManager.ResetPasswordAsync(user, token, password);
        }

        public Task<IdentityResult> AddPassword(
            User user,
          string password)
        {
            return UserManager.AddPasswordAsync(user, password);
        }

        public Task<IdentityResult> ChangePassword(
       User user,
       string currentPassword,
     string newPassword)
        {
            return UserManager.ChangePasswordAsync(user, currentPassword, newPassword);
        }

        public Task<bool> CheckPassword(
            User user,
          string password)
        {
            return UserManager.CheckPasswordAsync(user, password);
        }

        public Task<bool> CheckHasPassword(
       User user)
        {
            return UserManager.HasPasswordAsync(user);
        }

        Task<bool> IBaseService<User, int>.Delete(User entity)
        {
            throw new NotImplementedException();
        }

        Task<User> IBaseService<User, int>.Create(User entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IBaseService<User, int>.Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
