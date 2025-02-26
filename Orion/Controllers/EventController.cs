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
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]

    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<List<Event>> Get()
        {
            List<Event> bookings = await _eventService
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<Event>> Get(int id)
        {
            ApiResponse<Event> response = new ApiResponse<Event>();
            Event @event = await _eventService
                .Get(id, new CancellationToken());

            if (@event != null)
            {
                response.Data = @event;
            }
            else
            {
                response.ErrorCode = Shared.Enums.ErrorCodes.NotFound;
            }

            return response;
        }

        [HttpPost]
        public async Task<ApiResponse<Event>> Create(Event model)
        {
            ApiResponse<Event> response = new ApiResponse<Event>();

            model = await _eventService.Create(model);

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
                Event entity = await _eventService
                    .Get(id, new CancellationToken());

                bool deleted = await _eventService.Delete(entity);

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
