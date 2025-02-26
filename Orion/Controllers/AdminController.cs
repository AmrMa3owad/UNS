using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orion.Common;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using Orion.Shared.Exceptions;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("1.0")]

    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public async Task<List<Admin>> Get()
        {
            List<Admin> bookings = await _adminService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<Admin>> Get(int id)
        {
            ApiResponse<Admin> response = new ApiResponse<Admin>();
            Admin? admin = await _adminService
                .Get(id, new CancellationToken());

            if (admin != null)
            {
                response.Data = admin;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<Admin>> Create(Admin model)
        {
            ApiResponse<Admin> response = new ApiResponse<Admin>();

            model = await _adminService.Create(model);

            response.Data = model;

            if (response.Data == null)
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.CreateFailed;
            }

            return response;
        }

        [HttpDelete("{id}")]
        public async Task<ApiResponse<bool>> Delete(int id)

        {
            ApiResponse<bool> response = new ApiResponse<bool>();

            try
            {
                Admin? entity = await _adminService
                    .Get(id, new CancellationToken());

                bool deleted = await _adminService.Delete(entity);

                if (deleted)
                {
                    response.Data = deleted;
                }
                else
                {
                    response.ErrorCode = Shared.Enums.ErrorCodes.DeleteFailed;
                }
            }
            catch (NotFoundException)
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }
    }
}
