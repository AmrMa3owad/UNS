using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orion.Common;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using Orion.Shared.Exceptions;

namespace Orion.Controllers
{
    //[ApiController]
    //[Route("api/v{version:apiVersion}/[controller]")]
    //[ApiVersion("1.0")]

    //public class MaterialController : ControllerBase
    //{
    //    private readonly IMaterialService _materialService;

    //    public MaterialController(IMaterialService materialService)
    //    {
    //        _materialService = materialService;
    //    }

    //    [HttpGet]
    //    public async Task<List<Material>> Get()
    //    {
    //        List<Material> bookings = await _materialService
    //            .GetAll(new CancellationToken()).ToListAsync();

    //        return bookings;
    //    }

    //    [HttpGet("{id}")]
    //    //public async Task<ApiResponse<Material>> Get(int id)
    //    //{
    //    //    ApiResponse<Material> response = new ApiResponse<Material>();
    //    //    Material material = await _materialService
    //    //        .Get(id, new CancellationToken());

    //    //    if (material != null)
    //    //    {
    //    //        response.Data = material;
    //    //    }
    //    //    else
    //    //    {
    //    //        response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
    //    //    }

    //    //    return response;
    //    //}

    //    [HttpPost]
    //    public async Task<ApiResponse<Material>> Create(Material model)
    //    {
    //        ApiResponse<Material> response = new ApiResponse<Material>();

    //        model = await _materialService.Create(model);

    //        response.Data = model;

    //        if (response.Data == null)
    //        {
    //            response.ErrorCode = Shared.Enums.ErrorCodes.CreateFailed;
    //        }

    //        return response;
    //    }

    //    [HttpDelete("{id}")]
    //    //public async Task<ApiResponse<bool>> Delete(int id)
    //    //{
    //    //    ApiResponse<bool> response = new ApiResponse<bool>();

    //    //    try
    //    //    {
    //    //        Material entity = await _materialService
    //    //            .Get(id, new CancellationToken());

    //    //        bool deleted = await _materialService.Delete(entity);

    //    //        if (deleted)
    //    //        {
    //    //            response.Data = deleted;
    //    //        }
    //    //        else
    //    //        {
    //    //            response.ErrorCode = Shared.Enums.ErrorCodes.DeleteFailed;
    //    //        }
    //    //    }
    //    //    catch (NotFoundException)
    //    //    {
    //    //        response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
    //    //    }

    //    //    return response;
    //    //}
    //}
}
