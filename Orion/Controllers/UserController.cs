//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Orion.Common;
//using Orion.Domain.Models;
//using Orion.Infrastructure.Services;
//using Orion.Shared.Enums;

//namespace Orion.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class UserController : ControllerBase
//    {
//        private readonly IUserService _userService;

//        public UserController(IUserService userService)
//        {
//            _userService = userService;
//        }

//        [HttpPost("create")]
//        public async Task<ApiResponse<User>> Create(User user, string password)
//        {
//            ApiResponse<User> apiResponse = new ApiResponse<User>();
//            var result = await _userService.Create(user, password);
//            if (result.Succeeded)
//            {
//                apiResponse.Data = user;
//            }
//            else
//            {
//                apiResponse.ErrorCode = ErrorCodes.CreateFailed;
//            }
//            return apiResponse;
//        }

//        [HttpDelete("delete/{id}")]
//        public async Task<ApiResponse<bool>> Delete(int id)
//        {
//            ApiResponse<bool> apiResponse = new ApiResponse<bool>();
//            var user = await _userService.Get(id, CancellationToken.None);
//            if (user == null)
//            {
//                apiResponse.ErrorCode = ErrorCodes.NotFound;
//                return apiResponse;
//            }

//            var result = await _userService.Delete(user);
//            apiResponse.Data = result.Succeeded;
//            if (!result.Succeeded)
//            {
//                apiResponse.ErrorCode = ErrorCodes.UpdateFailed;
//            }
//            return apiResponse;
//        }

//        [HttpGet("get/{id}")]
//        public async Task<ApiResponse<User>> Get(int id)
//        {
//            ApiResponse<User> apiResponse = new ApiResponse<User>();
//            var user = await _userService.Get(id, CancellationToken.None);
//            if (user == null)
//            {
//                apiResponse.ErrorCode = ErrorCodes.NotFound;
//                return apiResponse;
//            }
//            apiResponse.Data = user;
//            return apiResponse;
//        }

//        [HttpGet("getAll")]
//        public async Task<List<User>> Get()
//        {
//            List<User> users = await _userService
//                .GetAll(new CancellationToken()).ToListAsync();

//            return users;
//        }

//        [HttpPost("signIn")]
//        public async Task<ApiResponse<User>> SignIn(string email, string password)
//        {
//            ApiResponse<User> apiResponse = new ApiResponse<User>();

//            var result = await _userService.SignIn(email, password, CancellationToken.None);
//            if (result.Succeeded)
//            {
//                apiResponse.Data = new User
//                {
//                    Password = password,
//                    Email = email
//                };
//            }
//            else
//            {
//                apiResponse.ErrorCode = ErrorCodes.UserInfoNotMatch;
//            }
//            return apiResponse;
//        }

//        [HttpPost("update")]
//        public async Task<ApiResponse<User>> Update(User user)
//        {
//            var response = new ApiResponse<User>();
//            var result = await _userService.Update(user);
//            if (result.Succeeded)
//            {
//                response.Data = user;
//            }
//            else
//            {
//                response.ErrorCode = ErrorCodes.UpdateFailed;
//            }
//            return response;
//        }

//        [HttpPost("confirmEmail")]
//        public async Task<ApiResponse<bool>> ConfirmEmail(User user, string token)
//        {
//            var response = new ApiResponse<bool>();
//            var result = await _userService.ConfirmEmailAsync(user, token);
//            response.Data = result.Succeeded;
//            if (!result.Succeeded)
//            {
//                response.ErrorCode = ErrorCodes.TokenInvalid;
//            }
//            return response;
//        }

//        [HttpPost("resetPassword")]
//        public async Task<ApiResponse<bool>> ResetPassword(User user, string token, string newPassword)
//        {
//            var response = new ApiResponse<bool>();
//            var result = await _userService.ResetPassword(user, token, newPassword);
//            response.Data = result.Succeeded;
//            if (!result.Succeeded)
//            {
//                response.ErrorCode = ErrorCodes.UserPasswordRequirementNotMet;
//            }
//            return response;
//        }

//        [HttpPost("changePassword")]
//        public async Task<ApiResponse<bool>> ChangePassword(User user, string currentPassword, string newPassword)
//        {
//            var response = new ApiResponse<bool>();
//            var result = await _userService.ChangePassword(user, currentPassword, newPassword);
//            response.Data = result.Succeeded;
//            if (!result.Succeeded)
//            {
//                response.ErrorCode = ErrorCodes.UserPasswordRequirementNotMet;
//            }
//            return response;
//        }

//        [HttpPost("checkPassword")]
//        public async Task<ApiResponse<bool>> CheckPassword(User user, string password)
//        {
//            var response = new ApiResponse<bool>();
//            var result = await _userService.CheckPassword(user, password);
//            response.Data = result;
//            if (!result)
//            {
//                response.ErrorCode = ErrorCodes.UserPasswordNotValid;
//            }
//            return response;
//        }

//        [HttpGet("hasPassword/{id}")]
//        public async Task<ApiResponse<bool>> HasPassword(int id)
//        {
//            var response = new ApiResponse<bool>();
//            var user = await _userService.Get(id, CancellationToken.None);
//            if (user == null)
//            {
//                response.ErrorCode = ErrorCodes.NotFound;
//                return response;
//            }

//            var result = await _userService.CheckHasPassword(user);
//            response.Data = result;
//            return response;
//        }
//    }
//}
